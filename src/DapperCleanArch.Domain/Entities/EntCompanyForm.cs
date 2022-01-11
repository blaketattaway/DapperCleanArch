using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DapperCleanArch.Domain.Entities
{
    public class EntCompanyForm
    {
        [JsonProperty("companyName")]
        [CompanyName(ErrorMessage = "CompanyName is invalid: CompanyName must contain a minimum of 5 characters and a maximum of 35, and it must start with 'Company Name:'")]
        public string CompanyName { get; set; }


        [JsonProperty("numberOfEmployees")]
        [Range(1, int.MaxValue, ErrorMessage = "NumberOfEmployees is invalid: NumberOfEmployees must be greater than 1")]
        public int NumberOfEmployees { get; set; }

        [JsonProperty("averageSalary")]
        [Range(0, int.MaxValue, ErrorMessage = "AverageSalary is invalid: AverageSalary must be greater than 0")]
        public int AverageSalary { get; set; }
    }

    public class CompanyNameAttribute : ValidationAttribute
    {
        public CompanyNameAttribute()
        {
            StartsWith = "Company Name:";
            MinLength = 5;
            MaxLength = 35;
        }
        public string StartsWith { get; set; }
        public int MinLength { get; set; }
        public int MaxLength { get; set; }

        public override bool IsValid(object value)
        {
            string? strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                int len = strValue.Length;
                return len >= MinLength && len <= MaxLength && strValue.StartsWith(StartsWith);
            }
            return false;
        }
    }
}
