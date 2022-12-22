using System;
using System.Collections.Generic;

namespace layer.access.models;

public partial class Empleado
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Salario { get; set; }

    public DateTime FNacimiento { get; set; }

    public string Correo { get; set; } = null!;
}
