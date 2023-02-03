using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quiz_game_design_and_coded_solution
{
    public partial class Form1 : Form
    {
        public static string User;
        public static string Forname;
        public static string Surname;
        public static string FORM;
        public static string DOB;
        public Form1()
        {
            InitializeComponent();
            User = System.Environment.UserName;
        }

        private void Form1_Load(object sender, EventArgs e) // this is the private method for the form1 load i.e the menu 
        {
            lblUserName.Text = User;
            DateTime LoginDateTime = DateTime.Now;
            textbox_Forname.Text = Forname;
            lblSurname_label.Text = Surname;
            lblform_label.Text = FORM;
            lblDateOfBirth_label.Text = DOB;



            string SQL = "INSERT INTO tblLogin  ( UserName, LoginDateTime) VALUES ('" + User + "','" + LoginDateTime + "');";
            DBCon.AmendAddInsertData(SQL);
            timer1.Start(); // this starts the timer for when the program runs

            /* string SQL_3 = "INSERT INTO tblUserScores (UserName, TestDate, Score, TestID) VALUES ('" + User + "','" + LoginDateTime + "','" + Score + "','" + TestID; "');";
             DBCon.AmendAddInsertData(SQL_3);
             string SQL_4 = "INSERT INTO tblTest (TestID, Subject) VALUES ('" + TestID + "','" + Subject; "';)";
             DBCon.AmendAddInsertData(SQL_4);*/


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e) // this private method is for the first button selection.
        {
            var myform = new General_knowledge_question();
            myform.Show();
        }

        private void button2_Click(object sender, EventArgs e) // this private method is for the second button selection.
        {
            var myform = new Entertainment();
            myform.Show();
        }

        private void button3_Click(object sender, EventArgs e) // this private method is for the third button selection.
        {
            var myform = new History();
            myform.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e) // this is a private method for the exit button for the main menu
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)// this private method for the button click for FoodandDrink for fourth button selection 
        {
            var myform = new Food_and_Drink();
            myform.Show();
        }

        private void textbox_Forname_TextChanged(object sender, EventArgs e)
        {
            Forname = textbox_Forname.Text;
            textbox_Forname.Text = Forname;
            this.Show();
        }

        private void textbox_Surname_TextChanged(object sender, EventArgs e)
        {
            Surname = textbox_Surname.Text;
            textbox_Surname.Text = Surname;
            this.Show();
        }

        private void textbox_Form_TextChanged(object sender, EventArgs e)
        {
            FORM = textbox_Form.Text;
            textbox_Form.Text = FORM;
            this.Show();
        }

        private void Textbox_DOB_TextChanged(object sender, EventArgs e)
        {
            DOB = Textbox_DOB.Text;
            Textbox_DOB.Text = DOB;
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the quiz game" + "," + textbox_Forname.Text + "to continue please select another mode");

            string Forename = textbox_Forname.Text;
            string Surname = textbox_Surname.Text;
            string FORM = textbox_Form.Text;
            string DOB = Textbox_DOB.Text;
            string SQL_2 = "INSERT INTO tblUser (UserName, Forname, Surname, Form, DOB) VALUES ('" + User + "','" + Forname + "','" + Surname + "','" + FORM + "','" + DOB + "');";
            DBCon.AmendAddInsertData(SQL_2);
        }
    }
}
