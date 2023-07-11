using Microsoft.Maui;
using System.Xml.Linq;

namespace quintoejercicio;

//<Summary>
//<Createddate>10/7/2023</createddate>
///<company>INDEL</company>
///<lastmodificationdate>10/7/2023</lastmodificationdate>
///<lastmodificationdescription>
///Construya un programa que dados la altura y la base de un rectángulo, calcule el perímetro y la superficie///
///</lastmodificationdescription>
//////<lastmodifierautor>Maycol Barrera</lastmodifierautor>
//</Summary>
public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
        double AlturaRectangulo = Convert.ToDouble(Altura.Text);
        double BaseRectangulo = Convert.ToDouble(basee.Text);


		double Perimetro =  2 * (AlturaRectangulo + BaseRectangulo);
            

            PerimetroRespuesta.Text = Convert.ToString(Perimetro);

        }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        double AlturaRectangulo = Convert.ToDouble(Altura.Text);
        double BaseRectangulo = Convert.ToDouble(basee.Text);


        double superficie = BaseRectangulo * AlturaRectangulo;

        SuperficieRespuesta.Text = Convert.ToString(superficie);

    }
}

