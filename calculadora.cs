using System.Collections.Generic;
using System.Globalization;
using System;
namespace Calculadora
{
    public class Calculadora
    {
        //implementando construtor
        public Calculadora(double _valor1, string _operador, double _valor2){

            this.Valor1 = _valor1;
            this.Operador = _operador;
            this.Valor2 = _valor2;
            

        }

        private Double _valor1;
        public Double Valor1
        {
            get { return _valor1; }
            set { _valor1 = value; }
        }

        private Double _valor2;
        public Double Valor2
        {
            get { return _valor2; }
            set { _valor2 = value; }
        }
        
        private string _operador;
        public string Operador
        {
            get { return _operador; }
            set { 
                    if(value == "*" ||value == "/" ||value == "+" ||value == "-"){

                        _operador = value;
                    
                    }else{

                        Console.WriteLine("Digite um operador valido");
                        
                    }

              
                }

        }

        private Double _resultado;
        public Double Resultado
        {
            get { 
                
                    if(this.Operador == "*"){

                        this.Multiplicar();
                        return this._resultado; 

                    }
                
                    if(this.Operador == "/"){

                        this.Dividir();
                        return this._resultado;
                    }

                    if(this.Operador == "+"){

                        this.Somar();
                        return this._resultado;
                    }

                    if(this.Operador == "-")

                        this.Diminuir();
                        return this._resultado;
                    
                }

        }
        

        //Método Multiplicar
        public void Multiplicar(){

               this._resultado = this.Valor1 * this.Valor2;
               
                   
        }

        //Método Dividir
        public void Dividir(){

            this._resultado = this.Valor1 / this.Valor2;
            
        }

        //Somar
        public void Somar(){

            this._resultado = this.Valor1 + this.Valor2;
            
        }

        //Método Diminuir
        public void Diminuir(){

            this._resultado = this.Valor1 - this.Valor2;
            
        }

        }     
    }