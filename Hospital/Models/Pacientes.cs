using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models
{
    public class Pacientes
    {
        public int Id { get; set; }

        public string? nombre { get; set; }

        public string? sexo { get; set; }

        public DateTime fechaNacimiento { get; set; }

        public string? email { get; set; }

        public double peso { get; set; }

        public double altura { get; set; }

        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string Condicion{
            get {
                var imc = peso / (altura * altura);
                var mensaje = "";

                if (imc < 18)
                {
                    mensaje = "Peso Bajo";
                }
                else if (imc > 18 && imc < 25)
                {
                    mensaje = "Peso Normal";
                }
                else if (imc > 25 && imc < 27)
                {
                    mensaje = "Sobre peso";
                }
                else if (imc > 27 && imc < 30)
                {
                    mensaje = "Obesidad grado I";
                }
                else if (imc > 30 && imc < 40)
                {
                    mensaje = "Obesidad grado II";
                }
                else if (imc >= 40)
                {
                    mensaje = "Obesidad grado III";
                }
                return mensaje;
            }
        }

        public string Color
        {
            get
            {
                var imc = peso / (altura * altura);
                var color = "";

                if (imc < 18)
                {
                    color = "Blue";
                }
                else if (imc > 18 && imc < 25)
                {
                    color = "Green";
                }
                else if (imc > 25 && imc < 27)
                {
                    color = "Yellow";
                }
                else if (imc > 27 && imc < 30)
                {
                    color = "Orange";
                }
                else if (imc > 30 && imc < 40)
                {
                    color = "Red";
                }
                else if (imc >= 40)
                {
                    color = "Darkred";
                }
                return color;
            }
        }
        public double IMC
        {
            get
            {
                var imc = peso / (altura * altura);

                return imc;
            }
        }

    }
}
