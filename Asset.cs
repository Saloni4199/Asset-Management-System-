using System;

namespace AssetManagementSystem{
    public class Asset{
        public string AssetCategory{ get; set; }
        
        public virtual  bool AddAsset(ClassForTest tempObj){
            return true;
        }
        public virtual  void UpdateAsset(){}
        public virtual  void DeleteAsset(){}
        public virtual  void SearchAsset(){}
        public virtual  void ListAsset(){}


    
    }    
}
