using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

public partial class Form1 : Form
{
    DbConnection db = new DbConnection();

    public Form1()
    {
        InitializeComponent();
    }
