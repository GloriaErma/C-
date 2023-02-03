using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPresenFunda_CRUD_LINQ
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // 2. Crear DATACONTEXT  es Mapeo de la base de datos,
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            // 1. Crear cadena conexión
            string Conexion = ConfigurationManager.ConnectionStrings["WPresenFunda_CRUD_LINQ.Properties.Settings.CadenaConCrudLinqSql"].ConnectionString;
            // 2. Crear DATACONTEXT  es Mapeo de la base de datos,
            dataContext = new DataClasses1DataContext(Conexion);
            //InsertaEmpresas();  // Ya se corrio
            //InsertaEmpleados();  // Ya se corrio
            //InsertaCargos();   // Ya se corrio
            InsertaEmpleadoCargo(); // Ya se corrio
        }
        public void InsertaEmpresas()
        {
            dataContext.ExecuteCommand("delete from Empresa");
            // 3. Crear intancia
            Empresa emp1 = new Empresa();
            // trabaja con las propiedades que se quieran
            emp1.Nombre = "Píldoras Informáticas";
            // inserte objeto
            dataContext.Empresa.InsertOnSubmit(emp1);
            // 3. Crear intancia
            Empresa emp2 = new Empresa();
            // trabaja con las propiedades que se quieran
            emp2.Nombre = "Google";
            // inserte objeto un registro
            dataContext.Empresa.InsertOnSubmit(emp2);
            ////////////////////////////////////////////////////////
            // toma efecto
            dataContext.SubmitChanges();
            // mostrarlo
            Ppal.ItemsSource = dataContext.Empresa;
        }
        public void InsertaEmpleados()
        {
            //dataContext.ExecuteCommand("delete from Empresa");
            // 3. Crear intancia
            //Empresa E = dataContext.Empresa
            //        .First("from E in dataContext.Empresa where Empresa=='Píldoras Informáticas' select E");
            Empresa emp1 = dataContext.Empresa.First(E => E.Nombre.Equals("Píldoras Informáticas"));
            Empresa emp2 = dataContext.Empresa.First(E => E.Nombre.Equals("Google"));
            List<Empleado> ListaEmpleados = new List<Empleado>();  // debe estar mapeado en DataClassess
            ListaEmpleados.Add(new Empleado { Nombre = "Juan", Apellido = "Díaz", EmpresaId = emp1.Id, });
            ListaEmpleados.Add(new Empleado { Nombre = "Ana", Apellido = "López", EmpresaId = emp2.Id, });
            ListaEmpleados.Add(new Empleado { Nombre = "Nika", Apellido = "Silva", EmpresaId = emp2.Id, });
            ListaEmpleados.Add(new Empleado { Nombre = "María", Apellido = "Pérez", EmpresaId = emp1.Id, });
            // inserte objeto lista
            dataContext.Empleado.InsertAllOnSubmit(ListaEmpleados);
            ////////////////////////////////////////////////////////
            // toma efecto
            dataContext.SubmitChanges();
            // mostrarlo
            Ppal.ItemsSource = dataContext.Empleado;
        }
        public void InsertaCargos()
        {
            // inserte objeto un registro, instanciando directamente
            dataContext.Cargo.InsertOnSubmit(new Cargo { Nombre = "Secretario/a" });
            dataContext.Cargo.InsertOnSubmit(new Cargo { Nombre = "Administrativo/a" });
            ////////////////////////////////////////////////////////
            // toma efecto en tablas
            dataContext.SubmitChanges();
            // mostrarlo en Grid
            Ppal.ItemsSource = dataContext.Cargo;
        }
        //public void InsertaEmpleadoCargo()
        //{
        //    // Insertar 1 X 1
        //    //Empleado Juan = dataContext.Empleado.First(e => e.Nombre.Equals("Juan"));
        //    //Empleado Ana = dataContext.Empleado.First(e => e.Nombre.Equals("Ana"));
        //    //Cargo c1 = dataContext.Cargo.First(c => c.Nombre.Equals("Secretario/a"));
        //    //Cargo c2 = dataContext.Cargo.First(c => c.Nombre.Equals("Administrativo/a"));
        //    //CargoEmpleado cJuan = new CargoEmpleado();
        //    //cJuan.Empleado = Juan;
        //    //cJuan.CargoId = c1.Id;
        //    // Insertar lista
        //    List<CargoEmpleado> ListaCargosEmpleados = new List<CargoEmpleado>();
        //    ListaCargosEmpleados.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 2 });
        //    ListaCargosEmpleados.Add(new CargoEmpleado { CargoId = 2, EmpleadoId = 3 });
        //    ListaCargosEmpleados.Add(new CargoEmpleado { CargoId = 1, EmpleadoId = 4 });
        //    // inserte objeto lista
        //    dataContext.CargoEmpleado.InsertAllOnSubmit(ListaCargosEmpleados);
        //    // toma efecto
        //    dataContext.SubmitChanges();
        //    // mostrarlo
        //    Ppal.ItemsSource = dataContext.CargoEmpleado;
        //}
        // 
        //public void InsertaEmpleadoCargo()
        //{
            
        //    //Empleado Juan = dataContext.Empleado.First(e => e.Nombre.Equals("Juan"));
        //    Empleado Ana = dataContext.Empleado.First(e => e.Nombre.Equals("Ana"));
        //    Empleado Maria = dataContext.Empleado.First(e => e.Nombre.Equals("María"));
        //    Empleado Nika = dataContext.Empleado.First(e => e.Nombre.Equals("Nika"));
        //    Cargo c1 = dataContext.Cargo.First(c => c.Nombre.Equals("Secretario/a"));
        //    Cargo c2 = dataContext.Cargo.First(c => c.Nombre.Equals("Administrativo/a"));
        //    //CargoEmpleado cJuan = new CargoEmpleado();
        //    //cJuan.Empleado = Juan;
        //    //cJuan.CargoId = c1.Id;
        //    // Insertar lista
        //    List<CargoEmpleado> ListaCargosEmpleados = new List<CargoEmpleado>();
        //    ListaCargosEmpleados.Add(new CargoEmpleado { Empleado = Ana, Cargo = c1 });
        //    ListaCargosEmpleados.Add(new CargoEmpleado { Empleado = Maria, Cargo = c2 });
        //    ListaCargosEmpleados.Add(new CargoEmpleado { Empleado = Nika, Cargo = c1 });
        //    // inserte objeto lista
        //    dataContext.CargoEmpleado.InsertAllOnSubmit(ListaCargosEmpleados);
        //    // toma efecto
        //    dataContext.SubmitChanges();
        //    // mostrarlo
        //    Ppal.ItemsSource = dataContext.CargoEmpleado;
        //}
        public void InsertaEmpleadoCargo()
        {
            //Empleado Juan = dataContext.Empleado.First(e => e.Nombre.Equals("Juan"));
            //Empleado Ana = dataContext.Empleado.First(e => e.Nombre.Equals("Ana"));
            //Empleado Maria = dataContext.Empleado.First(e => e.Nombre.Equals("María"));
            //Empleado Nika = dataContext.Empleado.First(e => e.Nombre.Equals("Nika"));
            //Cargo c1 = dataContext.Cargo.First(c => c.Nombre.Equals("Secretario/a"));
            //Cargo c2 = dataContext.Cargo.First(c => c.Nombre.Equals("Administrativo/a"));
            //CargoEmpleado cJuan = new CargoEmpleado();
            //cJuan.Empleado = Juan;
            //cJuan.CargoId = c1.Id;
            // Insertar lista
            List<CargoEmpleado> ListaCargosEmpleados = new List<CargoEmpleado>();
            ListaCargosEmpleados.Add(new CargoEmpleado {Empleado= dataContext.Empleado.First(e => e.Nombre.Equals("Nika")),
                    Cargo= dataContext.Cargo.First(c => c.Nombre.Equals("Secretario/a"))   });
            ListaCargosEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First(e => e.Nombre.Equals("María")),
                Cargo = dataContext.Cargo.First(c => c.Nombre.Equals("Administrativo/a"))
            });
            ListaCargosEmpleados.Add(new CargoEmpleado
            {
                Empleado = dataContext.Empleado.First(e => e.Nombre.Equals("Ana")),
                Cargo = dataContext.Cargo.First(c => c.Nombre.Equals("Secretario/a"))
            });

            // inserte objeto lista
            dataContext.CargoEmpleado.InsertAllOnSubmit(ListaCargosEmpleados);
            // toma efecto
            dataContext.SubmitChanges();
            // mostrarlo
            Ppal.ItemsSource = dataContext.CargoEmpleado;
        }
    }
}
