using L2;

//Standard ISO A4 paper dimensions are:
//    210mm x 297mm
//    8.27" x 11.69"

namespace L3
{
    public interface IReportCard<TModel> where TModel : IReportModel
    {
        int TotalPages { get; set; }
        void ShowPage(int pageIndex);
        void SetModel(TModel model);
    }
}
