using netProject.Models;
using netProject.Repositories;

namespace netProject.Services
{
    public class ContentService : IContentService
    {
        private readonly IContentRepository _repository;

        public ContentService(IContentRepository repository)
        {
            _repository = repository;
        }

        public async Task<object> GetComponent(string componentId)
        {
            return await _repository.GetComponent(componentId);
        }

        public async Task CheckIn(string itemId)
        {
            await _repository.CheckIn(itemId);
        }

        public async Task CheckOut(string itemId)
        {
            await _repository.CheckOut(itemId);
        }

        public async Task UndoCheckOut(string itemId)
        {
            await _repository.UndoCheckOut(itemId);
        }

        public async Task StopWorkflow(string itemId)
        {
            await _repository.StopWorkflow(itemId);
        }

        public async Task StartWorkflow(string itemId)
        {
            await _repository.StartWorkflow(itemId);
        }

        public async Task<object> GetAllPageComponents(string itemId)
        {
            return await _repository.GetAllPageComponents(itemId);
        }

        public async Task<object> BusinessProcessType(string publicationTcmId)
        {
            return await _repository.BusinessProcessType(publicationTcmId);
        }

        public async Task<object> GetMetaData(string componentId)
        {
            return await _repository.GetMetaData(componentId);
        }

        public async Task<object> CreateComponent(string schemaId, string componentName, string content)
        {
            return await _repository.CreateComponent(schemaId, componentName, content);
        }

        public async Task<object> GetComponentById(string componentId)
        {
            return await _repository.GetComponentById(componentId);
        }

        public async Task Publish(PublishData publishData)
        {
            await _repository.Publish(publishData);
        }

        public async Task UnPublish(PublishData publishData)
        {
            await _repository.UnPublish(publishData);
        }

        public async Task<object> GetPublishUrls(string documentId)
        {
            return await _repository.GetPublishUrls(documentId);
        }
    }
}