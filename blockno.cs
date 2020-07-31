namespace yz.logistic.classification.common {
    using REFERENCE_LANGUAGE_COMMON_CONSTANTS=language.common.constants;

    //
    //  class block number
    //
    class BlockNo{
        private string block_no;
        //constructors start
        public BlockNo(){
            this.constructorCommon(REFERENCE_LANGUAGE_COMMON_CONSTANTS.CS_SPACE);
        }
        public BlockNo(string arg){
            this.constructorCommon(arg);
        }
        private void constructorCommon(string arg){
            this.block_no=arg;
        }
        //constructors end
        public string get(){
            return this.block_no;
        }
        public bool isEqual(BlockNo arg){
            bool rv=false;
            if (this.block_no==arg.get()){
                rv=true;
            }
            return rv;
        }
        public void set(BlockNo arg){
            this.block_no=arg.get();
        }
    }
}