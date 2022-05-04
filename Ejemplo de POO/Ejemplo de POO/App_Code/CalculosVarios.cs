using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CalculosVarios
/// </summary>
public class CalculosVarios
{
    private int edad;
    public int diastrabajados;
    private double salariohora = 1800;

    /*
    public CalculosVarios(int edad, int dias) { 
        this.edad = edad; 
        this.diastrabajados = dias; 
    }
    */
        //
        // TODO: Add constructor logic here
        //

        
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value > 0 && value < 150)
                {
                    edad = value;
                }
                else
                {
                    edad = 0;
                }

            }
        }


        public double Salariohora
        {
            get
            {
                return salariohora;
            }
            set
            {
                salariohora = value;
            }
        }
        public double calcular_salario(int dt)
        {
            return dt * salariohora;
        }


}