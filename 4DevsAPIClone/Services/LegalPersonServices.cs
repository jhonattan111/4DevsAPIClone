using _4DevsAPIClone.Models.ControllerModels;
using System.Text.RegularExpressions;

namespace _4DevsAPIClone.Services;
public class LegalPersonServices : ILegalPersonServices
{
    public IEnumerable<string> GenerateCNPJ(CPFSettings cpfSettings)
    {
        List<string> cnpjs = new List<string>();

        for(int i = 0; i < cpfSettings.Quantity; i++)
        {

            var random = new Random();
            string cnpj = string.Empty;
            // 00.000.000/0000-00
            for (int j = 0; j <= 11; j++)
                cnpj = $"{cnpj}{(random.Next(0, 9).ToString())}";

            string digits = GenerateDigits(cnpj);

            cnpj += digits;

            if (cpfSettings.Formated)
                cnpj = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

            cnpjs.Add(cnpj);
        }

        return cnpjs;
    }

    public IEnumerable<bool> ValidateCNPJ(IEnumerable<string> cnpjs)
    {
        List<bool> validations = new List<bool>();

        string pattern = "[^0-9]";

        foreach(var cnpj in cnpjs)
        {
            var formated = Regex.Replace(cnpj, pattern, "");

            if (formated.Length != 14)
                validations.Add(false);

            var digits = GenerateDigits(formated);

            if (digits == formated.Substring(12, 2))
            {
                validations.Add(true);
                continue;
            }

            validations.Add(false);
        }

        return validations;
    }

    private static string GenerateDigits(string cnpj)
    {
        cnpj = cnpj.Substring(0,12);

        int[] num1Digits = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] num2Digits = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

        int verificatorDig1 = 0;
        int verificatorDig2 = 0;

        foreach (var item in cnpj.Select((value, i) => (value, i)))
        {
            verificatorDig1 += int.Parse(item.value.ToString()) * num1Digits[item.i];
            verificatorDig2 += int.Parse(item.value.ToString()) * num2Digits[item.i];
        }

        int restNum1 = verificatorDig1 % 11;
        restNum1 = restNum1 < 2 ? 0 : 11 - restNum1;

        verificatorDig2 += restNum1 * num2Digits[12];
        int restNum2 = verificatorDig2 % 11;

        restNum2 = restNum2 < 2 ? 0 : 11 - restNum2;

        return $"{restNum1}{restNum2}";
    }
}
