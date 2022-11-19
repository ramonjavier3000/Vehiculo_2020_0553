namespace Vehiculo_20200553.Data.Models;
using System.ComponentModel.DataAnnotations;
public class vehiculo
{
    [Key]
    public string? VehiculoID { get; set; }
    public string? Marca { get; set; }
    public string? Modelo { get; set; }
    public string? Año { get; set; }
    public string? Color { get; set; }
    
}
