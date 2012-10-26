using System;

namespace AmazonMWS1{

    internal class MWSProductsMain{

        private static void Main(string[] args){

            /************************************************************************
             * Access Key ID and Secret Access Key ID
             ***********************************************************************/
            String accessKeyId = "<Access Key ID>";
            String secretAccessKey = "<Secret Access Key>";
            String merchantId = "<Merchant Id>";
            String marketplaceId = "Market Place Id";

            /************************************************************************
             * The application name and version are included in each MWS call's
             * HTTP User-Agent field.
             ***********************************************************************/
            const string applicationName = "<Application Name>";
            const string applicationVersion = "<Version>";


            /***********************************************************************
             * Amazon MWS access information will be passed to the class
             ***********************************************************************/
            GetMatchingProduct mp = new GetMatchingProduct(accessKeyId, secretAccessKey, merchantId, marketplaceId,applicationName,applicationVersion);

            mp.GetProductInformation("<ASIN>"); //Place your book ASIN here

            /***********************************************************************
             * Demo Stuff
             ***********************************************************************/
            Console.WriteLine();
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();

        }
    }
}