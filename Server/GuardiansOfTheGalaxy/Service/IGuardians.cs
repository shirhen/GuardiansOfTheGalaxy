using GuardiansOfTheGalaxy.DAL.Entities;
using GuardiansOfTheGalaxy.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GuardiansOfTheGalaxy
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IGuardians" in both code and config file together.
    [ServiceContract]
    public interface IGuardians
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/board/{id}")]
        string GetBoard(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/worker/{id}")]
        worker GetWorker(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/search/worker/{param}/{value}")]
        IQueryable<worker> SearchWorker(string param, string value);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/db/init")]
        string InitDB();

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "api/db/drop")]
        string DropDB();
    }
}
