
using _4DevsAPIClone.Models.ControllerModels;
using _4DevsAPIClone.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _4DevsAPIClone.Services;
public class PhysicalPersonServices : IPhysicalPersonServices
{
    public IEnumerable<string> GenerateCPF(CPFSettings cpfSettings)
    {
        List<string> cpfs = new List<string>();
        
        for(int i = 0; i < cpfSettings.Quantity; i++)
        {
            var random = new Random();
            string cpf = string.Empty;
            // 000.000.000-00

            for (int j = 0; j <= 8; j++)
                cpf = $"{cpf}{random.Next(0, 9)}";

            var digits = GenerateDigits(cpf);

            cpf += digits;

            if (cpfSettings.Formated)
                cpf = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

            cpfs.Add(cpf);
        }

        return cpfs;
    }

    public IEnumerable<bool> ValidateCPF(IEnumerable<string> cpfs)
    {
        List<bool> validations = new List<bool>();

        
        
        foreach(var cpf in cpfs)
        {
            var validateCPF = FormatCPF(cpf);

            if (validateCPF.Length != 11)
                validations.Add(false);

            var digits = GenerateDigits(validateCPF);

            if (digits == validateCPF.Substring(9, 2))
            {
                validations.Add(true);
                continue;
            }

            validations.Add(false);
        }

        return validations;
    }

    private static string GenerateDigits(string cpf)
    {

        cpf = cpf.Substring(0, 9);

        int[] num1Digits = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] num2Digits = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

        int verificatorDig1 = 0;
        int verificatorDig2 = 0;

        foreach (var item in cpf.Select((value, i) => (value, i)))
        {
            verificatorDig1 += int.Parse(item.value.ToString()) * num1Digits[item.i];
            verificatorDig2 += int.Parse(item.value.ToString()) * num2Digits[item.i];
        }

        int restNum1 = verificatorDig1 % 11;
        int restNum2 = verificatorDig2 % 11;

        restNum1 = restNum1 == 10 ? 0 : restNum1;
        restNum2 = restNum2 == 10 ? 0 : restNum2;

        return $"{restNum1}{restNum2}";
    }

    private string FormatCPF(string cpf)
    {
        string pattern = "[^0-9]";
        return Regex.Replace(cpf, pattern, "");
    }
}
