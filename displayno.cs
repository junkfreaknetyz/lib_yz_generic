namespace yz.logistic.classification.common {
    using REFERENCE_LANGUAGE_COMMON_CONSTANTS=language.common.constants;
    //
    //  class shipping number
    //
    class DisplayNo {

        private string display_no;
        //constructors start
        public DisplayNo(){
            this.constructorCommon(REFERENCE_LANGUAGE_COMMON_CONSTANTS.CS_SPACE);
        }
        public DisplayNo(string arg){
            this.constructorCommon(arg);
        }
        private void constructorCommon(string arg){
            this.display_no=arg;
        }
        //constructors end
        public string get(){
            return this.display_no;
        }
        public bool isEqual(DisplayNo arg){
            bool rv=false;
            if (this.display_no==arg.get()){
                rv=true;
            }
            return rv;
        }
        public void set(DisplayNo arg){
            this.display_no=arg.get();
        }
    }

}