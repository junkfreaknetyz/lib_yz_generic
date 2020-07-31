namespace yz.logistic.classification.common {
    using REFERENCE_LANGUAGE_COMMON_CONSTANTS=language.common.constants;
    //
    //  class shipping number
    //
    class ShopCD {

        private string shop_cd;
        //constructors start
        public ShopCD(){
            this.constructorCommon(REFERENCE_LANGUAGE_COMMON_CONSTANTS.CS_SPACE);
        }
        public ShopCD(string arg){
            this.constructorCommon(arg);
        }
        private void constructorCommon(string arg){
            this.shop_cd=arg;
        }
        //constructors end
        public string get(){
            return this.shop_cd;
        }
        public bool isEqual(ShopCD arg){
            bool rv=false;
            if (this.shop_cd==arg.get()){
                rv=true;
            }
            return rv;
        }
        public void set(ShopCD arg){
            this.shop_cd=arg.get();
        }
    }

}