namespace shose
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            bool exitProgram = false;

            while (!exitProgram)
            {
                using (var formlogin = new Formlogin())
                {
                    if (formlogin.ShowDialog() == DialogResult.OK)
                    {
                        using (var formProduct = new FormProducts(
                            formlogin.CurrentUser, formlogin.IsGuest))
                        {
                            if (formProduct.ShowDialog() == DialogResult.Cancel)
                            {
                                continue;
                            }
                            else
                            {
                                exitProgram = true;
                            }
                        }
                    }
                    else
                    {
                        exitProgram = true;
                    }
                }
            }
        }
    }
}