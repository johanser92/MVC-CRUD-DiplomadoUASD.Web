using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC_CRUD_DiplomadoUASDCodeFirst.Model.Models;

namespace MVC_CRUD_DiplomadoUASDCodeFirst.Model.DAL
{
    public class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
    {
        protected override void Seed(EmpleadoContext context)
        {
            var Departamentos = new List<Departamento>
            {
                new Departamento{DepartamentoID=1, Descripcion="Programacion",},
                new Departamento{DepartamentoID=2, Descripcion="Recuersos Humanos",},
                new Departamento{DepartamentoID=3, Descripcion="Mercadeo",}

            };
            Departamentos.ForEach(s => context.Departamentos.Add(s));
            context.SaveChanges();

            var Empleados = new List<Empleado>
            {
                new Empleado{Nombres="Juan Carlos",Apellidos="Reyes Jimenez", Fecha_Ingreso=DateTime.Parse("2001-09-01")},
                 new Empleado{Nombres="Belkis",Apellidos="Jimenez", Fecha_Ingreso=DateTime.Parse("2011-09-01")},
                  new Empleado{Nombres="Carlos",Apellidos="Reyes", Fecha_Ingreso=DateTime.Parse("2021-09-01")},
                new Empleado{Nombres="Juan",Apellidos="Reyes Jimenez", Fecha_Ingreso=DateTime.Parse("2021-09-01")},
            };
            Empleados.ForEach(s => context.Empleados.Add(s));
            context.SaveChanges();

            var Registros = new List<Registro>
            {
                new Registro{EmpleadoID=1, DepartamentoID=1,Sueldo=Convert.ToDecimal(100000.00)},
                new Registro{EmpleadoID=2, DepartamentoID=1,Sueldo=Convert.ToDecimal(25000.00)},
                new Registro{EmpleadoID=3, DepartamentoID=2,Sueldo=Convert.ToDecimal(15000)},
                new Registro{EmpleadoID=4, DepartamentoID=2,Sueldo=Convert.ToDecimal(12000)},
            };
            Registros.ForEach(s => context.Registros.Add(s));
            context.SaveChanges();

        }



    }
}
