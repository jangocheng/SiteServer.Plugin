﻿using System.Collections.Generic;

namespace SiteServer.Plugin.Apis
{
    public interface IFilesApi
    {
        void MoveFiles(int sourceSiteId, int targetSiteId, List<string> relatedUrls);

        void AddWaterMark(int siteId, string filePath);

        string GetUploadFilePath(int siteId, string relatedPath);

        string GetTemporaryFilesPath(string relatedPath);

        string GetPluginPath(string relatedPath);

        string GetPluginUrl(string relatedUrl = "");

        string GetApiUrl(string relatedUrl = "");

        string GetApiPluginUrl(string relatedUrl = "");

        string GetApiPluginJsonUrl(string action = "", string id = "");

        string GetApiPluginHttpUrl(string action = "", string id = "");

        string GetSiteUrl(int siteId);

        string GetSiteUrl(int siteId, string relatedUrl);

        string GetSiteUrlByFilePath(string filePath);

        string GetChannelUrl(int siteId, int channelId);

        string GetContentUrl(int siteId, int channelId, int contentId);

        string GetRootUrl(string relatedUrl);

        string GetAdminDirectoryUrl(string relatedUrl);
    }
}
