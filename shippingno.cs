namespace yz.logistic.classification.common {
    using REFERENCE_LANGUAGE_COMMON_CONSTANTS=language.common.constants;
    //
    //  class shipping number
    //
    class ShippingNo {

        private string shipping_no;
        //constructors start
        public ShippingNo(){
            this.constructorCommon(REFERENCE_LANGUAGE_COMMON_CONSTANTS.CS_SPACE);
        }
        public ShippingNo(string arg){
            this.constructorCommon(arg);
        }
        private void constructorCommon(string arg){
            this.shipping_no=arg;
        }
        //constructors end
        public string get(){
            return this.shipping_no;
        }
        public bool isEqual(ShippingNo arg){
            bool rv=false;
            if (this.shipping_no==arg.get()){
                rv=true;
            }
            return rv;
        }
        public void set(ShippingNo arg){
            this.shipping_no=arg.get();
        }
    }

}