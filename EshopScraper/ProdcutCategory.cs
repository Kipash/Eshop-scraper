using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var prodcutCategory = ProdcutCategory.FromJson(jsonString);

namespace QuickType.Category
{
    public partial class ProdcutCategory
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonProperty("contextData")]
        public ContextData ContextData { get; set; }

        [JsonProperty("options")]
        public Options Options { get; set; }
    }

    public partial class ContextData
    {
        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("i18nOverrides")]
        public PuneHedgehog I18NOverrides { get; set; }

        [JsonProperty("i18nKeyOnly")]
        public string I18NKeyOnly { get; set; }

        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }

        [JsonProperty("platform")]
        public Platform Platform { get; set; }

        [JsonProperty("isDevice")]
        public bool IsDevice { get; set; }

        [JsonProperty("supportMobile")]
        public bool SupportMobile { get; set; }

        [JsonProperty("publicPath")]
        public Uri PublicPath { get; set; }

        [JsonProperty("cookies")]
        public PuneHedgehog Cookies { get; set; }

        [JsonProperty("unityVersion")]
        public string UnityVersion { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("unitySkin")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long UnitySkin { get; set; }

        [JsonProperty("ts")]
        public long Ts { get; set; }
    }

    public partial class PuneHedgehog
    {
    }

    public partial class Platform
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("layout")]
        public object Layout { get; set; }

        [JsonProperty("manufacturer")]
        public object Manufacturer { get; set; }

        [JsonProperty("name")]
        public object Name { get; set; }

        [JsonProperty("prerelease")]
        public object Prerelease { get; set; }

        [JsonProperty("product")]
        public object Product { get; set; }

        [JsonProperty("ua")]
        public string Ua { get; set; }

        [JsonProperty("version")]
        public object Version { get; set; }

        [JsonProperty("os")]
        public Os Os { get; set; }
    }

    public partial class Os
    {
        [JsonProperty("architecture")]
        public object Architecture { get; set; }

        [JsonProperty("family")]
        public object Family { get; set; }

        [JsonProperty("version")]
        public object Version { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("header")]
        public Header Header { get; set; }

        [JsonProperty("footer")]
        public Footer Footer { get; set; }

        [JsonProperty("product")]
        public ProductClass Product { get; set; }

        [JsonProperty("addToList")]
        public AddToList AddToList { get; set; }

        [JsonProperty("editList")]
        public EditList EditList { get; set; }

        [JsonProperty("addToCart")]
        public AddToCart AddToCart { get; set; }

        [JsonProperty("quickLook")]
        public QuickLook QuickLook { get; set; }

        [JsonProperty("comment")]
        public Comment Comment { get; set; }

        [JsonProperty("prompt")]
        public Prompt Prompt { get; set; }

        [JsonProperty("abuseReporting")]
        public AbuseReporting AbuseReporting { get; set; }

        [JsonProperty("modals")]
        public Modals Modals { get; set; }

        [JsonProperty("favorite")]
        public PuneHedgehog Favorite { get; set; }

        [JsonProperty("confirm")]
        public Confirm Confirm { get; set; }

        [JsonProperty("shareAsset")]
        public PuneHedgehog ShareAsset { get; set; }

        [JsonProperty("report")]
        public PuneHedgehog Report { get; set; }

        [JsonProperty("price")]
        public Price Price { get; set; }

        [JsonProperty("editor")]
        public Editor Editor { get; set; }

        [JsonProperty("QUERY")]
        public Query Query { get; set; }

        [JsonProperty("MUTATION")]
        public PuneHedgehog Mutation { get; set; }

        [JsonProperty("ENTITY")]
        public Entity Entity { get; set; }

        [JsonProperty("currentUrl")]
        public string CurrentUrl { get; set; }

        [JsonProperty("currentHost")]
        public string CurrentHost { get; set; }

        [JsonProperty("currentPath")]
        public string CurrentPath { get; set; }

        [JsonProperty("currentUserId")]
        public string CurrentUserId { get; set; }

        [JsonProperty("hideCallOut")]
        public bool HideCallOut { get; set; }

        [JsonProperty("expressCheckoutPayment")]
        public string ExpressCheckoutPayment { get; set; }

        [JsonProperty("currentPublisherId")]
        public string CurrentPublisherId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("userAvatar")]
        public string UserAvatar { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("productId")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long ProductId { get; set; }

        [JsonProperty("pageName")]
        public string PageName { get; set; }

        [JsonProperty("paging")]
        public PuneHedgehog Paging { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("i18nOverrides")]
        public PuneHedgehog I18NOverrides { get; set; }

        [JsonProperty("i18nKeyOnly")]
        public string I18NKeyOnly { get; set; }

        [JsonProperty("utcOffset")]
        public string UtcOffset { get; set; }

        [JsonProperty("platform")]
        public Platform Platform { get; set; }

        [JsonProperty("isDevice")]
        public bool IsDevice { get; set; }

        [JsonProperty("unityVersion")]
        public string UnityVersion { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("unitySkin")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long UnitySkin { get; set; }

        [JsonProperty("ts")]
        public long Ts { get; set; }
    }

    public partial class AbuseReporting
    {
        [JsonProperty("myForm")]
        public MyForm MyForm { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("closeDialog")]
        public bool CloseDialog { get; set; }
    }

    public partial class MyForm
    {
        [JsonProperty("description")]
        public MyFormDescription Description { get; set; }
    }

    public partial class MyFormDescription
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("validationRules")]
        public string[] ValidationRules { get; set; }
    }

    public partial class AddToCart
    {
        [JsonProperty("dialog")]
        public Dialog Dialog { get; set; }

        [JsonProperty("acceptedTerms")]
        public bool AcceptedTerms { get; set; }

        [JsonProperty("isoButton")]
        public IsoButton IsoButton { get; set; }

        [JsonProperty("terms")]
        public Terms Terms { get; set; }

        [JsonProperty("myAssets")]
        public PuneHedgehog MyAssets { get; set; }

        [JsonProperty("expressCheckoutInfo")]
        public ExpressCheckoutInfo ExpressCheckoutInfo { get; set; }

        [JsonProperty("subs")]
        public Subs Subs { get; set; }
    }

    public partial class Dialog
    {
        [JsonProperty("checkoutStatus")]
        public string CheckoutStatus { get; set; }

        [JsonProperty("acceptedTerms")]
        public bool AcceptedTerms { get; set; }
    }

    public partial class ExpressCheckoutInfo
    {
        [JsonProperty("tax")]
        public long Tax { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("authorized")]
        public bool Authorized { get; set; }

        [JsonProperty("taxConfirmed")]
        public bool TaxConfirmed { get; set; }
    }

    public partial class IsoButton
    {
        [JsonProperty("acceptedWarning")]
        public bool AcceptedWarning { get; set; }

        [JsonProperty("map")]
        public Map Map { get; set; }
    }

    public partial class Map
    {
        [JsonProperty("status")]
        public PuneHedgehog Status { get; set; }

        [JsonProperty("tos")]
        public PuneHedgehog Tos { get; set; }

        [JsonProperty("init")]
        public PuneHedgehog Init { get; set; }

        [JsonProperty("request")]
        public PuneHedgehog Request { get; set; }
    }

    public partial class Subs
    {
        [JsonProperty("granting")]
        public bool Granting { get; set; }

        [JsonProperty("grantEntitlementResult")]
        public object GrantEntitlementResult { get; set; }
    }

    public partial class Terms
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("nextAction")]
        public string NextAction { get; set; }

        [JsonProperty("cancelAction")]
        public string CancelAction { get; set; }
    }

    public partial class AddToList
    {
        [JsonProperty("updateStatus")]
        public PuneHedgehog UpdateStatus { get; set; }

        [JsonProperty("loaded")]
        public PuneHedgehog Loaded { get; set; }

        [JsonProperty("tip")]
        public PuneHedgehog Tip { get; set; }
    }

    public partial class Comment
    {
        [JsonProperty("update")]
        public PuneHedgehog Update { get; set; }

        [JsonProperty("form")]
        public CommentForm Form { get; set; }

        [JsonProperty("originalData")]
        public CommentOriginalData OriginalData { get; set; }

        [JsonProperty("isEdit")]
        public bool IsEdit { get; set; }

        [JsonProperty("showErrors")]
        public bool ShowErrors { get; set; }

        [JsonProperty("canPost")]
        public bool CanPost { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("nextAction")]
        public string NextAction { get; set; }

        [JsonProperty("reply")]
        public Reply Reply { get; set; }
    }

    public partial class CommentForm
    {
        [JsonProperty("id")]
        public Id Id { get; set; }

        [JsonProperty("packageId")]
        public Id PackageId { get; set; }

        [JsonProperty("subject")]
        public SubjectClass Subject { get; set; }

        [JsonProperty("description")]
        public SubjectClass Description { get; set; }

        [JsonProperty("rating")]
        public FormRating Rating { get; set; }
    }

    public partial class SubjectClass
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }

    public partial class Id
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class FormRating
    {
        [JsonProperty("value")]
        public long Value { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }
    }

    public partial class CommentOriginalData
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }
    }

    public partial class Reply
    {
        [JsonProperty("form")]
        public ReplyForm Form { get; set; }

        [JsonProperty("originalData")]
        public ReplyOriginalData OriginalData { get; set; }

        [JsonProperty("canPost")]
        public bool CanPost { get; set; }

        [JsonProperty("showErrors")]
        public bool ShowErrors { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("nextAction")]
        public string NextAction { get; set; }
    }

    public partial class ReplyForm
    {
        [JsonProperty("description")]
        public SubjectClass Description { get; set; }
    }

    public partial class ReplyOriginalData
    {
        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class Confirm
    {
        [JsonProperty("updateStatus")]
        public string UpdateStatus { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }

    public partial class EditList
    {
        [JsonProperty("form")]
        public EditListForm Form { get; set; }

        [JsonProperty("updateStatus")]
        public PuneHedgehog UpdateStatus { get; set; }
    }

    public partial class EditListForm
    {
        [JsonProperty("name")]
        public Name Name { get; set; }

        [JsonProperty("description")]
        public MyFormDescription Description { get; set; }

        [JsonProperty("status")]
        public Id Status { get; set; }
    }

    public partial class Name
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("isRequired")]
        public bool IsRequired { get; set; }

        [JsonProperty("validationRules")]
        public string[] ValidationRules { get; set; }
    }

    public partial class Editor
    {
        [JsonProperty("supportedLanguages")]
        public SupportedLanguage[] SupportedLanguages { get; set; }

        [JsonProperty("loginForm")]
        public LoginForm LoginForm { get; set; }

        [JsonProperty("initialized")]
        public bool Initialized { get; set; }

        [JsonProperty("canBack")]
        public bool CanBack { get; set; }

        [JsonProperty("canForward")]
        public bool CanForward { get; set; }

        [JsonProperty("download")]
        public Download Download { get; set; }
    }

    public partial class Download
    {
        [JsonProperty("localPath")]
        public PuneHedgehog LocalPath { get; set; }

        [JsonProperty("status")]
        public PuneHedgehog Status { get; set; }

        [JsonProperty("packageInfo")]
        public PuneHedgehog PackageInfo { get; set; }

        [JsonProperty("progress")]
        public PuneHedgehog Progress { get; set; }
    }

    public partial class LoginForm
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }
    }

    public partial class SupportedLanguage
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }

    public partial class Entity
    {
        [JsonProperty("Category")]
        public Dictionary<string, Category> Category { get; set; }

        [JsonProperty("Product")]
        public Dictionary<string, Product> Product { get; set; }

        [JsonProperty("ProductVersion")]
        public Dictionary<string, ProductTagValue> ProductVersion { get; set; }

        [JsonProperty("ProductPublisher")]
        public Dictionary<string, ProductPublisher> ProductPublisher { get; set; }

        [JsonProperty("ProductTag")]
        public Dictionary<string, ProductTagValue> ProductTag { get; set; }
    }

    public partial class Category
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        [JsonProperty("two_columns")]
        public bool? TwoColumns { get; set; }

        [JsonProperty("same_column")]
        public bool? SameColumn { get; set; }

        [JsonProperty("subs", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryId91[] Subs { get; set; }

        [JsonProperty("partners", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryId91[] Partners { get; set; }

        [JsonProperty("__typename")]
        public CategoryTypename Typename { get; set; }

        [JsonProperty("longName", NullValueHandling = NullValueHandling.Ignore)]
        public string LongName { get; set; }

        [JsonProperty("path", NullValueHandling = NullValueHandling.Ignore)]
        public CategoryId91[] Path { get; set; }

        [JsonProperty("pTagId", NullValueHandling = NullValueHandling.Ignore)]
        public string PTagId { get; set; }

        [JsonProperty("publishedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PublishedDate { get; set; }
    }

    public partial class CategoryId91
    {
        [JsonProperty("type")]
        public PurpleType Type { get; set; }

        [JsonProperty("id")]
        public string[] Id { get; set; }
    }

    public partial class Product
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("productId")]
        public string ProductId { get; set; }

        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("rating")]
        public ProductRating Rating { get; set; }

        [JsonProperty("currentVersion")]
        public CategoryId91 CurrentVersion { get; set; }

        [JsonProperty("reviewCount")]
        public long ReviewCount { get; set; }

        [JsonProperty("downloadSize")]
        public string DownloadSize { get; set; }

        [JsonProperty("assetCount")]
        public long AssetCount { get; set; }

        [JsonProperty("publisher")]
        public CategoryId91 Publisher { get; set; }

        [JsonProperty("mainImage")]
        public MainImage MainImage { get; set; }

        [JsonProperty("originalPrice")]
        public OriginalPrice OriginalPrice { get; set; }

        [JsonProperty("images")]
        public Image[] Images { get; set; }

        [JsonProperty("category")]
        public CategoryId91 Category { get; set; }

        [JsonProperty("firstPublishedDate")]
        public DateTimeOffset FirstPublishedDate { get; set; }

        [JsonProperty("publishNotes")]
        public string PublishNotes { get; set; }

        [JsonProperty("supportedUnityVersions")]
        public string[] SupportedUnityVersions { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("overlay")]
        public string Overlay { get; set; }

        [JsonProperty("overlayText")]
        public string OverlayText { get; set; }

        [JsonProperty("popularTags")]
        public CategoryId91[] PopularTags { get; set; }

        [JsonProperty("plusProSale")]
        public bool PlusProSale { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("upgrades")]
        public object Upgrades { get; set; }

        [JsonProperty("userTags", NullValueHandling = NullValueHandling.Ignore)]
        public object[] UserTags { get; set; }

        [JsonProperty("visualSimilarities({\"experiment\":\"\",\"variation\":\"\",\"limit\":10})", NullValueHandling = NullValueHandling.Ignore)]
        public object[] VisualSimilaritiesExperimentVariationLimit10 { get; set; }
    }

    public partial class Image
    {
        [JsonProperty("type")]
        public ImageType Type { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("thumbnailUrl")]
        public string ThumbnailUrl { get; set; }

        [JsonProperty("__typename")]
        public ImageTypename Typename { get; set; }
    }

    public partial class MainImage
    {
        [JsonProperty("big")]
        public string Big { get; set; }

        [JsonProperty("facebook")]
        public object Facebook { get; set; }

        [JsonProperty("small")]
        public string Small { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("icon75")]
        public string Icon75 { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class OriginalPrice
    {
        [JsonProperty("itemId")]
        public string ItemId { get; set; }

        [JsonProperty("originalPrice")]
        public string OriginalPriceOriginalPrice { get; set; }

        [JsonProperty("finalPrice")]
        public string FinalPrice { get; set; }

        [JsonProperty("isFree")]
        public bool IsFree { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("entitlementType")]
        public string EntitlementType { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class Discount
    {
        [JsonProperty("save")]
        public long Save { get; set; }

        [JsonProperty("percentage")]
        public long Percentage { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("saleType")]
        public string SaleType { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class ProductRating
    {
        [JsonProperty("average")]
        public long Average { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class ProductPublisher
    {
        [JsonProperty("id")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("supportUrl")]
        public string SupportUrl { get; set; }

        [JsonProperty("supportEmail")]
        public string SupportEmail { get; set; }

        [JsonProperty("gaAccount")]
        public string GaAccount { get; set; }

        [JsonProperty("gaPrefix")]
        public string GaPrefix { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class ProductTagValue
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        [JsonProperty("__typename")]
        public CategoryTypename Typename { get; set; }

        [JsonProperty("longName", NullValueHandling = NullValueHandling.Ignore)]
        public string LongName { get; set; }

        [JsonProperty("pTagId", NullValueHandling = NullValueHandling.Ignore)]
        public string PTagId { get; set; }

        [JsonProperty("publishedDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PublishedDate { get; set; }
    }

    public partial class Footer
    {
        [JsonProperty("signUp")]
        public SignUp SignUp { get; set; }

        [JsonProperty("supportedLanguages")]
        public SupportedLanguage[] SupportedLanguages { get; set; }

        [JsonProperty("supportedCurrencies")]
        public SupportedCurrency[] SupportedCurrencies { get; set; }
    }

    public partial class SignUp
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }

    public partial class SupportedCurrency
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("setting")]
        public Setting Setting { get; set; }

        [JsonProperty("fetchNotification")]
        public bool FetchNotification { get; set; }

        [JsonProperty("loaded")]
        public PuneHedgehog Loaded { get; set; }

        [JsonProperty("searchBar")]
        public SearchBar SearchBar { get; set; }

        [JsonProperty("initFeature")]
        public bool InitFeature { get; set; }
    }

    public partial class SearchBar
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("categoryId")]
        public string CategoryId { get; set; }

        [JsonProperty("categorySelectShow")]
        public bool CategorySelectShow { get; set; }

        [JsonProperty("selectedCategory")]
        public object SelectedCategory { get; set; }

        [JsonProperty("updateStatus")]
        public string UpdateStatus { get; set; }

        [JsonProperty("history")]
        public PuneHedgehog History { get; set; }

        [JsonProperty("showSuggest")]
        public bool ShowSuggest { get; set; }
    }

    public partial class Setting
    {
        [JsonProperty("headerTop")]
        public long HeaderTop { get; set; }

        [JsonProperty("scrollTop")]
        public long ScrollTop { get; set; }

        [JsonProperty("currHeaderTop")]
        public long CurrHeaderTop { get; set; }

        [JsonProperty("windowWidth")]
        public long WindowWidth { get; set; }

        [JsonProperty("windowHeight")]
        public long WindowHeight { get; set; }
    }

    public partial class Modals
    {
        [JsonProperty("modalStack")]
        public object[] ModalStack { get; set; }
    }

    public partial class Price
    {
        [JsonProperty("forceRating")]
        public PuneHedgehog ForceRating { get; set; }
    }

    public partial class ProductClass
    {
        [JsonProperty("loadStatus")]
        public LoadStatus LoadStatus { get; set; }

        [JsonProperty("reviewVariables")]
        public ReviewVariables ReviewVariables { get; set; }

        [JsonProperty("userTagsInit")]
        public UserTagsInit UserTagsInit { get; set; }

        [JsonProperty("packagePreview")]
        public PackagePreview PackagePreview { get; set; }

        [JsonProperty("tags")]
        public Tags Tags { get; set; }

        [JsonProperty("visualSimilarities")]
        public object[] VisualSimilarities { get; set; }
    }

    public partial class LoadStatus
    {
        [JsonProperty("recommendations")]
        public string Recommendations { get; set; }

        [JsonProperty("topReviews")]
        public string TopReviews { get; set; }
    }

    public partial class PackagePreview
    {
        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("previewStatus")]
        public string PreviewStatus { get; set; }

        [JsonProperty("assetStatus")]
        public string AssetStatus { get; set; }

        [JsonProperty("noFetch")]
        public bool NoFetch { get; set; }

        [JsonProperty("fetchMap")]
        public object[] FetchMap { get; set; }

        [JsonProperty("previewUrlMap")]
        public object[] PreviewUrlMap { get; set; }

        [JsonProperty("fileTree")]
        public PuneHedgehog FileTree { get; set; }
    }

    public partial class ReviewVariables
    {
        [JsonProperty("rows")]
        public long Rows { get; set; }

        [JsonProperty("page")]
        public long Page { get; set; }

        [JsonProperty("sort_by")]
        public string SortBy { get; set; }
    }

    public partial class Tags
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("voteStatus")]
        public PuneHedgehog VoteStatus { get; set; }
    }

    public partial class UserTagsInit
    {
        [JsonProperty("2943")]
        public bool The2943 { get; set; }
    }

    public partial class Prompt
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("closeDialog")]
        public bool CloseDialog { get; set; }
    }

    public partial class Query
    {
        [JsonProperty("promo")]
        public Promo Promo { get; set; }

        [JsonProperty("categories")]
        public CategoryId91[] Categories { get; set; }

        [JsonProperty("feature")]
        public Feature Feature { get; set; }

        [JsonProperty("productETag({\"id\":\"2943\"})")]
        public CategoryId91 ProductETagId2943 { get; set; }

        [JsonProperty("product({\"id\":\"2943\"})")]
        public CategoryId91 ProductId2943 { get; set; }

        [JsonProperty("category({\"id\":\"91\"})")]
        public CategoryId91 CategoryId91 { get; set; }
    }

    public partial class Feature
    {
        [JsonProperty("subscriber")]
        public bool Subscriber { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class Promo
    {
        [JsonProperty("homeHeaderLinks")]
        public HomeHeaderLink[] HomeHeaderLinks { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }

        [JsonProperty("calloutNewsletter")]
        public CalloutNewsletter[] CalloutNewsletter { get; set; }
    }

    public partial class CalloutNewsletter
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("keyImage")]
        public KeyImage KeyImage { get; set; }

        [JsonProperty("link")]
        public object Link { get; set; }

        [JsonProperty("promoType")]
        public string PromoType { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("titleEnglish")]
        public string TitleEnglish { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class KeyImage
    {
        [JsonProperty("homeCarousel")]
        public string HomeCarousel { get; set; }

        [JsonProperty("homeCarouselHighres")]
        public string HomeCarouselHighres { get; set; }

        [JsonProperty("homeCallOut")]
        public string HomeCallOut { get; set; }

        [JsonProperty("homeCallOutHighres")]
        public string HomeCallOutHighres { get; set; }

        [JsonProperty("homeSecondary")]
        public string HomeSecondary { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class HomeHeaderLink
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("promoType")]
        public string PromoType { get; set; }

        [JsonProperty("__typename")]
        public string Typename { get; set; }
    }

    public partial class QuickLook
    {
        [JsonProperty("fetchMap")]
        public PuneHedgehog FetchMap { get; set; }

        [JsonProperty("preload")]
        public PuneHedgehog Preload { get; set; }

        [JsonProperty("zoomViewer")]
        public ZoomViewer ZoomViewer { get; set; }
    }

    public partial class ZoomViewer
    {
        [JsonProperty("viewIndex")]
        public long ViewIndex { get; set; }

        [JsonProperty("preview")]
        public bool Preview { get; set; }

        [JsonProperty("loadStatus")]
        public string LoadStatus { get; set; }

        [JsonProperty("loadedList")]
        public object[] LoadedList { get; set; }
    }

    public partial class Options
    {
        [JsonProperty("isServer")]
        public bool IsServer { get; set; }
    }

    public enum PurpleType { Id };

    public enum CategoryTypename { Category, ProductTag, ProductVersion };

    public enum ImageType { Screenshot, Youtube };

    public enum ImageTypename { ProductImage };

    public partial class ProdcutCategory
    {
        public static ProdcutCategory FromJson(string json) => JsonConvert.DeserializeObject<ProdcutCategory>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ProdcutCategory self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                CategoryTypenameConverter.Singleton,
                PurpleTypeConverter.Singleton,
                ImageTypenameConverter.Singleton,
                ImageTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }

    internal class CategoryTypenameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CategoryTypename) || t == typeof(CategoryTypename?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Category":
                    return CategoryTypename.Category;
                case "ProductTag":
                    return CategoryTypename.ProductTag;
                case "ProductVersion":
                    return CategoryTypename.ProductVersion;
            }
            throw new Exception("Cannot unmarshal type CategoryTypename");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CategoryTypename)untypedValue;
            switch (value)
            {
                case CategoryTypename.Category:
                    serializer.Serialize(writer, "Category");
                    return;
                case CategoryTypename.ProductTag:
                    serializer.Serialize(writer, "ProductTag");
                    return;
                case CategoryTypename.ProductVersion:
                    serializer.Serialize(writer, "ProductVersion");
                    return;
            }
            throw new Exception("Cannot marshal type CategoryTypename");
        }

        public static readonly CategoryTypenameConverter Singleton = new CategoryTypenameConverter();
    }

    internal class PurpleTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleType) || t == typeof(PurpleType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "id")
            {
                return PurpleType.Id;
            }
            throw new Exception("Cannot unmarshal type PurpleType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleType)untypedValue;
            if (value == PurpleType.Id)
            {
                serializer.Serialize(writer, "id");
                return;
            }
            throw new Exception("Cannot marshal type PurpleType");
        }

        public static readonly PurpleTypeConverter Singleton = new PurpleTypeConverter();
    }

    internal class ImageTypenameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageTypename) || t == typeof(ImageTypename?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "ProductImage")
            {
                return ImageTypename.ProductImage;
            }
            throw new Exception("Cannot unmarshal type ImageTypename");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImageTypename)untypedValue;
            if (value == ImageTypename.ProductImage)
            {
                serializer.Serialize(writer, "ProductImage");
                return;
            }
            throw new Exception("Cannot marshal type ImageTypename");
        }

        public static readonly ImageTypenameConverter Singleton = new ImageTypenameConverter();
    }

    internal class ImageTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ImageType) || t == typeof(ImageType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "screenshot":
                    return ImageType.Screenshot;
                case "youtube":
                    return ImageType.Youtube;
            }
            throw new Exception("Cannot unmarshal type ImageType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ImageType)untypedValue;
            switch (value)
            {
                case ImageType.Screenshot:
                    serializer.Serialize(writer, "screenshot");
                    return;
                case ImageType.Youtube:
                    serializer.Serialize(writer, "youtube");
                    return;
            }
            throw new Exception("Cannot marshal type ImageType");
        }

        public static readonly ImageTypeConverter Singleton = new ImageTypeConverter();
    }
}
