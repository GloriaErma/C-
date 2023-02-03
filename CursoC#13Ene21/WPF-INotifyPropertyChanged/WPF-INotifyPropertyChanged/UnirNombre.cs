using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotifyPropertyChanged
{
    // debo implementar los métodos de la Interfaz
    public class UnirNombre : INotifyPropertyChanged
    {
        private string nombre, apellido, nombre_completo;
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string property)
        {
            // segun documentacion oficial WEB .NET Framework 4.8
            // INotifyPropertyChanged.PropertyChanged Event
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        // implementar propiedades == campos
        // {Binding Path=Nombre,Mode=TwoWay}
        // {Binding Path=Apellido,Mode=TwoWay}
        // {Binding Path=Nombre_completo,Mode=TwoWay}
        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre_completo");
            }    
        }
        public string Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                OnPropertyChanged("Nombre_completo");
            }

            }
        public string Nombre_completo
        {
            get { nombre_completo = Nombre + " " + Apellido;
                return nombre_completo; 
            }
            set { }
        }
    }
}
