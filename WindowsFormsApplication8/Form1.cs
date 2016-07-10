using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //englishPicture = global::WindowsFormsApplication8.Properties.Resources.miami;
        //this.pictureBox1.Image = englishPicture;
        //
        //syntax for changing image
        //

        //
        //
        //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterNextHotkey);
        //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.exitHotkey);
        //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterSubmitHotkey);
        //
        // if designer cancels your eventhandlers on designer.cs copy from here and repaste aroudn the form1.this area
        //
        public static bool correct;
        public static int questionNumber;


        private void newClick(object sender, EventArgs e)
        {
            q1();
        }

        private void q1()//Beans  |||  Frijoles
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.MichiganBean_Pinto;
            this.textBox1.Text = "Beans";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 1;
            correct = false;
        }

        private void q2()//Goodbye  |||  Adios
        {
            
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Goodbye;
            this.textBox1.Text = "Goodbye";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 2;
            correct = false;
        }

        private void q3()//Please  |||  Por Favor
        {
            
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources._200_s;
            this.textBox1.Text = "Please";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 3;
            correct = false;
        }

        private void q4()//Thank you  |||  Gracias
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Thankyou;
            this.textBox1.Text = "Thank you";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 4;
            correct = false;
        }

        private void q5()//Yes ||| Si
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Yes;
            this.textBox1.Text = "Yes";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 5;
            correct = false;
        }

        private void q6()//No ||| No
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.No;
            this.textBox1.Text = "No";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 6;
            correct = false;
        }

        private void q7()//Brain |||  El Cerebro/cerebro
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.activebrain;
            this.textBox1.Text = "Brain";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 7;
            correct = false;
        }

        private void q8()//Wolf  |||  El Lobo
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Wolf;
            this.textBox1.Text = "Wolf";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 8;
            correct = false;
        }

        private void q9()//River  |||  Rio
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.River;
            this.textBox1.Text = "River";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 9;
            correct = false;
        }

        private void q10()//Christianity |||  el Cristianismo
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Christianity;
            this.textBox1.Text = "Christianity";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 10;
            correct = false;
        }

        private void q11()//Blue ||| Azul
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Blue;
            this.textBox1.Text = "Blue";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 11;
            correct = false;
        }

        private void q12()//Heart |||  El Corazon/Corazon
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.heart;
            this.textBox1.Text = "Heart";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 12;
            correct = false;
        }

        private void q13()//What Time is it?  |||  Que Hora es?
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.WhatTime;
            this.textBox1.Text = "What Time is it";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 13;
            correct = false;
        }

        private void q14()//Why?  |||  Por Que?
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Why;
            this.textBox1.Text = "Why";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 14;
            correct = false;
        }

        private void q15()//Who?  |||  Quien?
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Who;
            this.textBox1.Text = "Who";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 15;
            correct = false;
        }

        private void q16()//Red ||| Rojo
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Red;
            this.textBox1.Text = "Red";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 16;
            correct = false;
        }

        private void q17()//Pants |||  los Pantelones/Pantelones
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Pants;
            this.textBox1.Text = "Pants";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 17;
            correct = false;
        }

        private void q18()//You are Welcome(its nothing)  |||  De Nada
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Welcome;
            this.textBox1.Text = "You are Welcome(its nothing)";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 18;
            correct = false;
        }

        private void q19()//Open  |||  Abierto
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.open;
            this.textBox1.Text = "Open";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 19;
            correct = false;
        }

        private void q20()//Bathroom  |||  Bano
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Bathroom;
            this.textBox1.Text = "Bathroom";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 20;
            correct = false;
        }

        private void q21()//God  |||  el Dios
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.God;
            this.textBox1.Text = "God";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 21;
            correct = false;
        }

        private void q22()//Sheep  |||  Oveja
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Sheep;
            this.textBox1.Text = "Sheep";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 22;
            correct = false;
        }

        private void q23()//Rainbow  |||  El Arco Iris
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Rainbow;
            this.textBox1.Text = "Rainbow";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 23;
            correct = false;
        }

        private void q24()//Monkey  |||  El Mono
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Monkey;
            this.textBox1.Text = "Monkey";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 24;
            correct = false;
        }

        private void q25()//Direction  |||  Direccion
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Direction;
            this.textBox1.Text = "Direction";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 25;
            correct = false;
        }

        private void q26()//Where are you  |||  Donde Estas
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.WhereAreYou;
            this.textBox1.Text = "Where are you";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 26;
            correct = false;
        }

        private void q27()//white ||| blanco
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.White;
            this.textBox1.Text = "White";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 27;
            correct = false;
        }

        private void q28()//Cloud |||  Niebla
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Cloud;
            this.textBox1.Text = "Cloud";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 28;
            correct = false;
        }

        private void q29()//My love, Love ||| Mi Amor
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Love;
            this.textBox1.Text = "My love, Love,";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 29;
            correct = false;
        }

        private void q30()//Although  |||  Aunque/  a pesar de que/  bien que
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Although;
            this.textBox1.Text = "Although";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 30;
            correct = false;
        }

        private void q31()//Necessary  |||  Necesario
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Necessary;
            this.textBox1.Text = "Necessary";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 31;
            correct = false;
        }

        private void q32()//Precise  |||  Preciso
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Precise;
            this.textBox1.Text = "Precise";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 32;
            correct = false;
        }

        private void q33()//I Feel Good  |||  Me Siento Bien
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Ifeelgood;
            this.textBox1.Text = "I Feel Good";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 33;
            correct = false;
        }

        private void q34()//Waterfall  |||  Cascada
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Waterfall;
            this.textBox1.Text = "Waterfall";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 34;
            correct = false;
        }

        private void q35()//Programming  |||  Programación
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Programming;
            this.textBox1.Text = "Programming";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 35;
            correct = false;
        }

        private void q36()//Computer  |||  Computadora
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Computer;
            this.textBox1.Text = "Computer";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 36;
            correct = false;
        }

        private void q37()//Bank  |||  Banco
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Bank;
            this.textBox1.Text = "Bank";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 37;
            correct = false;
        }

        private void q38()//School  |||  La Escuela
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.School;
            this.textBox1.Text = "School";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 38;
            correct = false;
        }

        private void q39()//City  |||  la ciudad
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.City;
            this.textBox1.Text = "City";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 39;
            correct = false;
        }

        private void q40()//Black  |||  Negro
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Black;
            this.textBox1.Text = "Black";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 40;
            correct = false;
        }

        private void q41()//House  |||  Casa
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.House;
            this.textBox1.Text = "House";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 41;
            correct = false;
        }

        private void q42()//Yellow ||| Amarillo
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Yellow;
            this.textBox1.Text = "Yellow";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 42;
            correct = false;
        }

        private void q43()//How Much is it worth?  |||  Cuanto Vale
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Worth;
            this.textBox1.Text = "How Much is it Worth?";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 43;
            correct = false;
        }

        private void q44()//Tall  |||  alto, grande, 
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Mr_Tall;
            this.textBox1.Text = "Tall;";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 44;
            correct = false;
        }

        private void q45()//Low, Short  |||  Bajo, corto, breve, poco
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Short;
            this.textBox1.Text = "Short";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 45;
            correct = false;
        }

        private void q46()//What Happened  |||  Que Paso
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.What_Happened;
            this.textBox1.Text = "What Happened";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 46;
            correct = false;
        }

        private void q47()//Whats up  |||  Que Pasa
        {
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.WhatsUp;
            this.textBox1.Text = "Whats up";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 47;
            correct = false;
        }

        private void q48()//Sky  |||  El Ciello/Cielo
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 48;
            correct = false;
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Sky;
            this.textBox1.Text = "Sky";
        }


        private void q49()//Jungle  |||  Selva
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 49;
            correct = false;
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.jungle;
            this.textBox1.Text = "Jungle";
        }

        private void q50()//Pink  |||  Rosado
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            questionNumber = 50;
            correct = false;
            this.pictureBox1.Image = global::WindowsFormsApplication8.Properties.Resources.Pink;
            this.textBox1.Text = "Pink";
        }

        private void win()
        {

        }

        private void ifCorrect()
        {
            textBox3.Text = "Correct!";
        }

        private void ifIncorrect()
        {
            textBox3.Text = "Incorrect!";
        }

        public void submit()
        {
            if (questionNumber == 1)
            {
                if (textBox2.Text == "frijole")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Frijole")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "frijoles")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Frijoles")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }


            }
            if (questionNumber == 2)
            {
                if (textBox2.Text == "adios")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Adios")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "adio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Adio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la despedida")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }



            if (questionNumber == 3)
            {
                if (textBox2.Text == "Por Favor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Por favor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "por favor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "PorFavor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Porfavor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "porfavor")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 4)
            {
                if (textBox2.Text == "Gracias")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "gracias")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Gracia")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "gracia")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 5)
            {
                if (textBox2.Text == "Si")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "si")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Adelante")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "adelante")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 6)
            {
                if (textBox2.Text == "No")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "no")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "nope")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 7)
            {
                if (textBox2.Text == "Cerebro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "El Cerebro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cerebro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el cerebro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Seso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "El Seso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Seso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Cerebro")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 8)
            {
                if (textBox2.Text == "Lobo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Lobo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "El Lobo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el lobo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "lobo")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 9)
            {
                if (textBox2.Text == "Rio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "rio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Rio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el rio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "El Rio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Fluvial")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "fluvial")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "ribereno")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Ribereno")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 10)
            {
                if (textBox2.Text == "Cristianismo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cristianismo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Cristianismo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el cristianismo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la religion cristiana")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 11)
            {
                if (textBox2.Text == "Azul")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "azul")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Azul")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el azul")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 12)
            {
                if (textBox2.Text == "Corazon")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "corazon")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Corazon")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "El Corazon")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Centro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "centro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Alma")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "alma")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 13)
            {
                if (textBox2.Text == "Que hora es")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que hora es")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que Hora Es")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que hora es?")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que Hora Es?")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 14)
            {
                if (textBox2.Text == "Por que?")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Por Que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Por que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Por Que?")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "por que?")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "por que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Tomala")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "tomala")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 15)
            {
                if (textBox2.Text == "Quien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "quien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Quiens")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "quiens")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 16)
            {
                if (textBox2.Text == "Rojo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "rojo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "tinto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Tinto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "ruboroso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Ruboroso")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 17)
            {
                if (textBox2.Text == "Pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los Pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Los pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Los Pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los pantelones")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los Pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Los pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Los Pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los pantelone")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 18)
            {
                if (textBox2.Text == "De nada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "de nada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Denada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "De Nada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "de Nada")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 19)
            {
                if (textBox2.Text == "Abierto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "abierto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "abrirse")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Abrirse")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Abrir")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "abrir")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 20)
            {
                if (textBox2.Text == "Bano")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "bano")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Banos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "banos")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 21)
            {
                if (textBox2.Text == "Dios")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "dios")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Dio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "dio")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 22)
            {
                if (textBox2.Text == "Oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "La Oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el grey")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el oveja")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 23)
            {
                if (textBox2.Text == "el Arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                if (textBox2.Text == "El Arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                if (textBox2.Text == "el arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Arco Iris")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los Arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los arco iris")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 24)
            {
                if (textBox2.Text == "Mono")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "mono")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Mono")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Mico")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "mico")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el mico")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Mico")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 25)
            {
                if (textBox2.Text == "Direccion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "direccion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la direccion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Direccion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "rumbo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Rumbo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Rumbo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el rumbo")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 26)
            {
                if (textBox2.Text == "Donde estas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "donde estas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Donde Estas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Donde esta")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "donde esta")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Donde Esta")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 27)
            {
                if (textBox2.Text == "Blanco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "blanco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Palido")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "palido")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "gringo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Gringo")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 28)
            {
                if (textBox2.Text == "Nube")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "nube")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Nubes")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "nubes")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la nube")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Nube")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Nubarron")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Anublar")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "anublar")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 29)
            {
                if (textBox2.Text == "mi Amor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Mi Amor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Amor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "amor")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el amado")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Amado")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Vida")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la vida")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "amar")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Amar")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Carino")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el carino")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 30)
            {
                if (textBox2.Text == "Aunque")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "aunque")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "a pesar de que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "A pesar de que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "bien que")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Bien Que")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 31)
            {
                if (textBox2.Text == "necesario")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Necesario")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 32)
            {
                if (textBox2.Text == "Preciso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "preciso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Exacto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "exacto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Claro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "claro")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 33)
            {
                if (textBox2.Text == "Me Siento Bien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "me siento bien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Me Siento bien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "me Siento bien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "me Siento Bien")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "me Siento Feliz")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "me siento feliz")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 34)
            {
                if (textBox2.Text == "Cascada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cascada")
                {
                    ifCorrect();
                    correct = true;
                }
                if (textBox2.Text == "Cascadas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cascadas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Cascada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "La cascada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la cascada")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "las caida de agua")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Las Caida de agua")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    correct = false;
                }
            }
            if (questionNumber == 35)
            {
                if (textBox2.Text == "Programacion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "programacion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "programacions")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Programacions")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Programacion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la programacion")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el programa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Programa")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 36)
            {
                if (textBox2.Text == "Computadora")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "computadora")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Computadoras")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "computadoras")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Computadora")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la computadora")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Computador")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el computador")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 37)
            {
                if (textBox2.Text == "Banco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "banco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Bancos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el banco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Banco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Orilla")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la orilla")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Banca")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la banca")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 38)
            {
                if (textBox2.Text == "la escuela")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Escuela")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "La Escuela")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Colegio")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la universidad")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Universidad")
                {
                    ifCorrect();
                    correct = true;
                }

                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 39)
            {
                if (textBox2.Text == "Ciudad")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "ciudad")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la ciudad")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Ciudad")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los urbe")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "los Urbe")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Urbano")
                {
                    ifCorrect();
                    correct = true;

                }
                else if (textBox2.Text == "urbano")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 40)
            {
                if (textBox2.Text == "Negro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "negro")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Negros")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "negros")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 41)
            {
                if (textBox2.Text == "Casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "mi casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "mi Casa")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 42)
            {
                if (textBox2.Text == "Amarillo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "amarillo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Amarillos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "amarillos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "amarillecer")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 43)
            {
                if (textBox2.Text == "Cuanto vale")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cuanto vale")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Cuanto Vale")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 44)
            {
                if (textBox2.Text == "Altos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "altos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Alto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "alto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Grande")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "grande")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 45)
            {
                if (textBox2.Text == "Corto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Cortos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "corto")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cortos")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Breve")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "breve")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Bajo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "bajo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Pequeno")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "pequeno")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Poco")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "poco")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 46)
            {
                if (textBox2.Text == "Que Paso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que paso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que paso")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que Paso")
                {
                    ifCorrect();
                    correct = true;
                }

                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 47)
            {
                if (textBox2.Text == "Que Pasa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que pasa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que Pasa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que pasa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que Tal")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Que tal")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "que tal")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            
            if (questionNumber == 48)
            {
                if (textBox2.Text == "Cielo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "cielo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Cielo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el cielo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Bombear")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "bombear")
                {
                    ifCorrect();
                    correct = true;
                }
                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 49)
            {
                if (textBox2.Text == "Selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Selvas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "selvas")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "La Selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "La selva")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Jungla")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "jungla")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Jungla")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la jungla")
                {
                    ifCorrect();
                    correct = true;
                }

                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
            if (questionNumber == 50)
            {
                if (textBox2.Text == "Rosado")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "rosado")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "Rosa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "rosa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la Rosa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "la rosa")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el rojillo")
                {
                    ifCorrect();
                    correct = true;
                }
                else if (textBox2.Text == "el Rojillo")
                {
                    ifCorrect();
                    correct = true;
                }

                else
                {
                    ifIncorrect();
                    correct = false;
                }
            }
        }
        public void next()
        {
            if(questionNumber ==1)
            {
                if (correct == true)
                {
                    q2();
                }
            }
            if (questionNumber == 2)
            {
                if(correct == true)
                {
                    q3();
                }
            }
            if (questionNumber == 3)
            {
                if (correct == true)
                {
                    q4();
                }
            }
            if (questionNumber == 4)
            {
                if (correct == true)
                {
                    q5();
                }
            }
            if (questionNumber == 5)
            {
                if (correct == true)
                {
                    q6();
                }
            }
            if (questionNumber == 6)
            {
                if (correct == true)
                {
                    q7();
                }
            }

            if (questionNumber == 7)
            {
                if (correct == true)
                {
                    q8();
                }
            }
            if (questionNumber == 8)
            {
                if (correct == true)
                {
                    q9();
                }
            }
            if (questionNumber == 9)
            {
                if (correct == true)
                {
                    q10();
                }
            }
            if (questionNumber == 10)
            {
                if (correct == true)
                {
                    q11();
                }
            }
            if (questionNumber == 11)
            {
                if (correct == true)
                {
                    q12();
                }
            }
            if (questionNumber == 12)
            {
                if (correct == true)
                {
                    q13();
                }
            }
            if (questionNumber == 13)
            {
                if (correct == true)
                {
                    q14();
                }
            }
            if (questionNumber == 14)
            {
                if (correct == true)
                {
                    q15();
                }
            }
            if (questionNumber == 15)
            {
                if (correct == true)
                {
                    q16();
                }
            }
            if (questionNumber == 16)
            {
                if (correct == true)
                {
                    q17();
                }
            }
            if (questionNumber == 17)
            {
                if (correct == true)
                {
                    q18();
                }
            }
            if (questionNumber == 18)
            {
                if (correct == true)
                {
                    q19();
                }
            }
            if (questionNumber == 19)
            {
                if (correct == true)
                {
                    q20();
                }
            }
            if (questionNumber == 20)
            {
                if (correct == true)
                {
                    q21();
                }
            }
            if (questionNumber == 21)
            {
                if (correct == true)
                {
                    q22();
                }
            }
            if (questionNumber == 22)
            {
                if (correct == true)
                {
                    q23();
                }
            }
            if (questionNumber == 23)
            {
                if (correct == true)
                {
                    q24();
                }
            }
            if (questionNumber == 24)
            {
                if (correct == true)
                {
                    q25();
                }
            }
            if (questionNumber == 25)
            {
                if (correct == true)
                {
                    q26();
                }
            }
            if (questionNumber == 26)
            {
                if (correct == true)
                {
                    q27();
                }
            }
            if (questionNumber == 27)
            {
                if (correct == true)
                {
                    q28();
                }
            }
            if (questionNumber == 28)
            {
                if (correct == true)
                {
                    q29();
                }
            }
            if (questionNumber == 29)
            {
                if (correct == true)
                {
                    q30();
                }
            }
            if (questionNumber == 30)
            {
                if (correct == true)
                {
                    q31();
                }
            }
            if (questionNumber == 31)
            {
                if (correct == true)
                {
                    q32();
                }
            }
            if (questionNumber == 32)
            {
                if (correct == true)
                {
                    q33();
                }
            }
            if (questionNumber == 33)
            {
                if (correct == true)
                {
                    q34();
                }
            }
            if (questionNumber == 34)
            {
                if (correct == true)
                {
                    q35();
                }
            }
            if (questionNumber == 35)
            {
                if (correct == true)
                {
                    q36();
                }
            }
            if (questionNumber == 36)
            {
                if (correct == true)
                {
                    q37();
                }
            }
            if (questionNumber == 37)
            {
                if (correct == true)
                {
                    q38();
                }
            }
            if (questionNumber == 38)
            {
                if (correct == true)
                {
                    q39();
                }
            }
            if (questionNumber == 39)
            {
                if (correct == true)
                {
                    q40();
                }
            }
            if (questionNumber == 40)
            {
                if (correct == true)
                {
                    q41();
                }
            }
            if (questionNumber == 41)
            {
                if (correct == true)
                {
                    q42();
                }
            }
            if (questionNumber == 42)
            {
                if (correct == true)
                {
                    q43();
                }
            }
            if (questionNumber == 43)
            {
                if (correct == true)
                {
                    q44();
                }
            }
            if (questionNumber == 44)
            {
                if (correct == true)
                {
                    q45();
                }
            }
            if (questionNumber == 45)
            {
                if (correct == true)
                {
                    q46();
                }
            }
            if (questionNumber == 46)
            {
                if (correct == true)
                {
                    q47();
                }
            }
            if (questionNumber == 47)
            {
                if (correct == true)
                {
                    q48();
                }
            }
            if (questionNumber == 48)
            {
                if (correct == true)
                {
                    q49();
                }
            }
            if (questionNumber == 49)
            {
                if (correct == true)
                {
                    q50();
                }
            }
            if (questionNumber == 50)
            {
                if (correct == true)
                {
                    win();
                }
            }


        }

        private void exitClick(object sender, EventArgs e)
        {

            this.Close();
        }

        public void exitHotkey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Close();
            }
        }


        public void enterSubmitHotkey(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                submit();

            }
        }



        public void enterNextHotkey(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if (correct == true)
                {
                    next();
                }
            }
        }

        public void revealHotkey(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.F1)
            {
                if (correct == false)
                {
                    reveal();
                }
            }
        }


        public void submitClick(object sender, EventArgs e)
        {
            submit();
        }

        public void nextClick(object sender, EventArgs e)
        {
            next();
        }
        public void revealClick(object sender, EventArgs e)
        {
            reveal();
        }

        public void reveal()
        {
            if (questionNumber == 1)
            {
                if (correct == false)
                {
                    textBox4.Text = "Frijole";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }

             }
            if(questionNumber == 2)
            {
                if (correct == false)
                {
                    textBox4.Text = "Adios";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 3)
            {
                if (correct == false)
                {
                    textBox4.Text = "Por Favor";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 4)
            {
                if (correct == false)
                {
                    textBox4.Text = "Gracias";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 5)
            {
                if (correct == false)
                {
                    textBox4.Text = "Si";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 6)
            {
                if (correct == false)
                {
                    textBox4.Text = "No, Nope";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 7)
            {
                if (correct == false)
                {
                    textBox4.Text = "el Cerebro, Cerebro";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 8)
            {
                if (correct == false)
                {
                    textBox4.Text = "El Lobo, Lobo";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 9)
            {
                if (correct == false)
                {
                    textBox4.Text = "Rio";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 10)
            {
                if (correct == false)
                {
                    textBox4.Text = "Cristianismo, el Cristianismo";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 11)
            {
                if (correct == false)
                {
                    textBox4.Text = "Azul";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }

            }
            if (questionNumber == 12)
            {
                if (correct == false)
                {
                    textBox4.Text = "Corazon, el Corazon";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 13)
            {
                if (correct == false)
                {
                    textBox4.Text = "Que Hora es";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 14)
            {
                if (correct == false)
                {
                    textBox4.Text = "Por Que";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 15)
            {
                if (correct == false)
                {
                    textBox4.Text = "Quien";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 16)
            {
                if (correct == false)
                {
                    textBox4.Text = "Rojo";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 17)
            {
                if (correct == false)
                {
                    textBox4.Text = "Pantelones, Los Pantelones";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 18)
            {
                if (correct == false)
                {
                    textBox4.Text = "De Nada";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 19)
            {
                if (correct == false)
                {
                    textBox4.Text = "Abierto";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 20)
            {
                if (correct == false)
                {
                    textBox4.Text = "Bano";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 21)
            {
                if (correct == false)
                {
                    textBox4.Text = "Dios, el Dios";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }

            }
            if (questionNumber == 22)
            {
                if (correct == false)
                {
                    textBox4.Text = "Oveja";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 23)
            {
                if (correct == false)
                {
                    textBox4.Text = "el Arco Iris";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 24)
            {
                if (correct == false)
                {
                    textBox4.Text = "Mono, el Mono";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 25)
            {
                if (correct == false)
                {
                    textBox4.Text = "Direccion, el Direccion";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 26)
            {
                if (correct == false)
                {
                    textBox4.Text = "Donde Estas";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 27)
            {
                if (correct == false)
                {
                    textBox4.Text = "Blanco";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 28)
            {
                if (correct == false)
                {
                    textBox4.Text = "Niebla";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 29)
            {
                if (correct == false)
                {
                    textBox4.Text = "Amor, Mi Amor, la vida";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 30)
            {
                if (correct == false)
                {
                    textBox4.Text = "Aunque, a pesar de que, bien que";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 31)
            {
                if (correct == false)
                {
                    textBox4.Text = "Necessario";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }

            }
            if (questionNumber == 32)
            {
                if (correct == false)
                {
                    textBox4.Text = "Preciso";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 33)
            {
                if (correct == false)
                {
                    textBox4.Text = "Me Siento Bien";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 34)
            {
                if (correct == false)
                {
                    textBox4.Text = "Cascada";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 35)
            {
                if (correct == false)
                {
                    textBox4.Text = "Programacion";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 36)
            {
                if (correct == false)
                {
                    textBox4.Text = "Computadora, el Computadora";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 37)
            {
                if (correct == false)
                {
                    textBox4.Text = "Banco, el Banco";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 38)
            {
                if (correct == false)
                {
                    textBox4.Text = "La Escuela, Colegio, la universidad";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 39)
            {
                if (correct == false)
                {
                    textBox4.Text = "la Ciudad, Ciudad";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 40)
            {
                if (correct == false)
                {
                    textBox4.Text = "Negro";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 41)
            {
                if (correct == false)
                {
                    textBox4.Text = "Casa, mi Casa";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }

            }
            if (questionNumber == 42)
            {
                if (correct == false)
                {
                    textBox4.Text = "Amarillo";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 43)
            {
                if (correct == false)
                {
                    textBox4.Text = "Cuanto Vale";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 44)
            {
                if (correct == false)
                {
                    textBox4.Text = "Alto, Grande";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 45)
            {
                if (correct == false)
                {
                    textBox4.Text = "Bajo, Corto, Breve, Poco";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 46)
            {
                if (correct == false)
                {
                    textBox4.Text = "Que Paso";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 47)
            {
                if (correct == false)
                {
                    textBox4.Text = "Que Pasa";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 48)
            {
                if (correct == false)
                {
                    textBox4.Text = "El Ciello";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 49)
            {
                if (correct == false)
                {
                    textBox4.Text = "Selva, Jungla, la Jungla,";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
            if (questionNumber == 50)
            {
                if (correct == false)
                {
                    textBox4.Text = "Rosado";
                    correct = true;
                    textBox3.Text = "Freebie!";
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
