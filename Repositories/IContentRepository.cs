using netProject.Models;

namespace netProject.Repositories
{
    public interface IContentRepository
    {
        Task<object> GetComponent(string componentId);
        Task CheckIn(string itemId);
        Task CheckOut(string itemId);
        Task UndoCheckOut(string itemId);
        Task StopWorkflow(string itemId);
        Task StartWorkflow(string itemId);
        Task<object> GetAllPageComponents(string itemId);
        Task<object> BusinessProcessType(string publicationTcmId);
        Task<object> GetMetaData(string componentId);
        Task<object> CreateComponent(string schemaId, string componentName, string content);
        Task<object> GetComponentById(string componentId);
        Task Publish(PublishData publishData);
        Task UnPublish(PublishData publishData);
        Task<object> GetPublishUrls(string documentId);
    }
}