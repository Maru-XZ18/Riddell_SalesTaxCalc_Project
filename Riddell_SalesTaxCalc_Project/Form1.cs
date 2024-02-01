namespace Riddell_SalesTaxCalc_Project;
public partial class CarSalesForm : Form
{
    public CarSalesForm()
    {
     
    }

   
    private void CalculateButton_Click(object sender, EventArgs e)
    {
        
        decimal baseCost = decimal.Parse(baseCostTextBox.Text);

        
        string warrantyChoice = warrantyComboBox.SelectedItem.ToString();

        
        string dealershipLocation = dealershipComboBox.SelectedItem.ToString();

        
        decimal salesTax = CalculateSalesTax(baseCost, dealershipLocation);

      
        decimal warrantyCost = CalculateWarrantyCost(warrantyChoice);

        
        decimal totalVehicleCost = baseCost + salesTax + warrantyCost;

        
        totalVehicleCostLabel.Text = $"Total Vehicle cost is ${totalVehicleCost:N2}";
    }

    private decimal CalculateSalesTax(decimal baseCost, string dealershipLocation)
    {
        decimal salesTaxRate = 0.0m;

       
        if (dealershipLocation == "WA")
        {
            salesTaxRate = 0.10m;
        }
        else if (dealershipLocation == "OR")
        {
            salesTaxRate = 0.08m;
        }

        
        decimal salesTax = baseCost * salesTaxRate;

        return salesTax;
    }

   
    private decimal CalculateWarrantyCost(string warrantyChoice)
    {
        decimal warrantyCost = 0.0m;

        
        if (warrantyChoice == "No Warranty")
        {
            warrantyCost = 0.0m;
        }
        else if (warrantyChoice == "One Year")
        {
            warrantyCost = 500.0m;
        }
        else if (warrantyChoice == "Two Year")
        {
            warrantyCost = 800.0m;
        }
        else if (warrantyChoice == "Three Year")
        {
            warrantyCost = 1000.0m;
        }

        return warrantyCost;
    }
}

