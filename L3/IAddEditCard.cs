
namespace L3
{
    public interface IAddEditCard<T> where T: L1.BaseRecord
    {
        /// <summary>
        /// Text content will be display in card
        /// </summary>
        string Title { get; }

        /// <summary>
        /// prepare data for edit case
        /// </summary>
        /// <param name="model"></param>
        void PrepareEditModel(T model);
        /// <summary>
        /// Prepare data for add case
        /// </summary>
        void PrepareAddModel();

        /// <summary>
        /// Bind model to UI
        /// </summary>
        /// <param name="model"></param>
        void SetModel(T model);        
        /// <summary>
        /// Get data in UI
        /// </summary>
        /// <returns></returns>
        T GetModel();
    }
}
