using ClimateMonitor.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace ClimateMonitor.Services.Models;

public class DeviceReadingRequest
{
    [Required]
    [ValidateExpression(ErrorMessage = "The firmware value does not match semantic versioning format.") ] 
    public string FirmwareVersion { get; set; } = string.Empty;

    [Required]
    public decimal Temperature { get; set; }

    [Required]
    public decimal Humidity { get; set; }
}
