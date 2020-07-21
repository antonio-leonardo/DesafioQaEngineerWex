using SpecFlow.Challenge.Model.Abstractions;

namespace SpecFlow.Challenge.Model
{
    /// <summary>
    /// Any Item at Amazon Site
    /// </summary>
    public class AmazonObjectItem : IObjectItem<AmazonObjectType>
    {
        private readonly string _facePageHeader;
        public AmazonObjectItem()
        {
        }

        public AmazonObjectItem(string facePageHeader = null)
        {
            this._facePageHeader = facePageHeader;
        }

        public long ID { get; set; }
        public string Name { get; set; }
        public string FacePageHeader
        {
            get
            {
                return (string.IsNullOrWhiteSpace(this._facePageHeader)) ? this.Name : this._facePageHeader;
            }
        }
        public double Price { get; set; }
        public AmazonObjectType ObjectType { get; set; }
        public bool ValidationChecker()
        {
            return this.Name == this.FacePageHeader;
        }
    }
}