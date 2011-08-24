﻿using QuickFix;

namespace TradeClient
{
    public class TradeClientApp : QuickFix.Application
    {
        public override void FromAdmin(Message message, SessionID sessionID)
        {
            System.Console.WriteLine("FromAdmin: " + message.ToString());
        }

        public override void FromApp(Message message, SessionID sessionID)
        {
            System.Console.WriteLine("FromApp: " + message.ToString());
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    char action = QueryAction();
                    if (action == '1')
                        QueryEnterOrder();
                    else if (action == '2')
                        QueryCancelOrder();
                    else if (action == '3')
                        QueryReplaceOrder();
                    else if (action == '4')
                        QueryMarketDataRequest();
                    else if (action == '5')
                        break;
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine("Message Not Sent: " + e.Message);
                }
            }
        }

        char QueryAction()
        {
            System.Console.Write("\n" 
                + "1) Enter Order\n"
                + "2) Cancel Order\n" 
                + "3) Replace Order\n"
                + "4) Market data test\n"
                + "5) Quit\n"
                + "Action: "
            );
            
            string line = System.Console.ReadLine().Trim();
            if(line.Length != 1)
                throw new System.Exception("Invalid action");

            char val = line[0];
            switch(val)
            {
                case '1': case '2': case '3': case '4': case '5': break;
                default: throw new System.Exception("Invalid action");
            }
            return val;
        }

        void QueryEnterOrder()        { throw new System.NotImplementedException("FIXME - not implemented"); }
        void QueryCancelOrder()       { throw new System.NotImplementedException("FIXME - not implemented"); }
        void QueryReplaceOrder()      { throw new System.NotImplementedException("FIXME - not implemented"); }
        void QueryMarketDataRequest() { throw new System.NotImplementedException("FIXME - not implemented"); }
    }
}