using System.Collections.Generic;
using PilotoQ1Net.Models.Dtos;

namespace PilotoQ1Net.Models.Interface
{
    public interface IContent
    {
        Content AddContent(Content dataContent);
        Content UpdateContent(long Id, Content dataContent);
        bool DeleteContent(long Id);
        Content GetContent(long Id);
        List<Content> GetContentList();
    }
}