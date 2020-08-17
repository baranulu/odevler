
namespace wfa_ödev_extension_metot
{
  public static class Class2
    {
        public static int Exmethot(this string str)
        {
            return int.Parse (str.ToLower()
                .Replace('ö', 'o')
                 .Replace('ü', 'u')
                 .Replace('ı', 'i')
                 .Replace('ğ', 'g')
                 .Replace('ç', 'c')
                 .Replace('ş', 's')
                 .Replace('ç', 'c'));
        }
        static void main (string[] args)
        {
            string str1 = "ÖYKÜ";
            int n = str1.Exmethot();
            System.Windows.Forms.MessageBox.Show("Result: {0}", n.ToString());

        }
    }
}
