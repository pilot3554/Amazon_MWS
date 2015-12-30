using System;

namespace AmazonMWS1{

    internal class MWSProductsMain{

        private static void Main(string[] args){

            /************************************************************************
             * Access Key ID and Secret Access Key ID
             ***********************************************************************/
            String accessKeyId = "AKIAIYVOST33BPAYD3KA";
            String secretAccessKey = "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";
            String merchantId = "A25SBROR340M5M";
            String marketplaceId = "ATVPDKIKX0DER";

            /************************************************************************
             * The application name and version are included in each MWS call's
             * HTTP User-Agent field.
             ***********************************************************************/
            const string applicationName = "Odachoo";
            const string applicationVersion = "1.0";


            /***********************************************************************
             * Amazon MWS access information will be passed to the class
             ***********************************************************************/
            GetMatchingProduct mp = new GetMatchingProduct(accessKeyId, secretAccessKey, merchantId, marketplaceId,applicationName,applicationVersion);

            mp.GetProductInformation("B00E9PMMX0"); //Place your book ASIN here

            /***********************************************************************
             * Demo Stuff
             ***********************************************************************/
            Console.WriteLine();
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }
    }
}