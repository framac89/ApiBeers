using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using System.Collections.Generic;

public class Birrerie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }

    [MaxLength(200)]
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [MaxLength(200)]
    [JsonPropertyName("brewery")]
    public string? Brewery { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("rating")]
    public string? Rating { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("sub_category_1")]
    public string? Sub_category_1 { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("sub_category_2")]
    public string? Sub_category_2 { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("sub_category_3")]
    public string? Sub_category_3 { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("abv")]
    public string? Abv { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("ibu")]
    public string? Ibu { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("calories_per_serving_12oz")]
    public string? Calories_per_serving_12oz { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("carbs_per_serving_12oz")]
    public string? Carbs_per_serving_12oz { get; set; }

    [JsonPropertyName("tasting_notes")]
    public string? Tasting_notes { get; set; }

    [JsonPropertyName("food_pairing")]
    public string? Food_pairing { get; set; }

    [MaxLength(200)]
    [JsonPropertyName("suggested_glassware")]
    public string? Suggested_glassware { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("serving_temp_f")]
    public string? Serving_temp_f { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("serving_temp_c")]
    public string? Serving_temp_c { get; set; }

    [MaxLength(100)]
    [JsonPropertyName("beer_type")]
    public string? Beer_type { get; set; }

    [JsonPropertyName("features")]
    public string? Features { get; set; }

    public Birrerie(
        string? sku,
        string? name,
        string? brewery,
        string? rating,
        string? category,
        string? sub_category_1,
        string? sub_category_2,
        string? sub_category_3,
        string? description,
        string? region,
        string? country,
        string? abv,
        string? ibu,
        string? calories_per_serving_12oz,
        string? carbs_per_serving_12oz,
        string? tasting_notes,
        string? food_pairing,
        string? suggested_glassware,
        string? serving_temp_f,
        string? serving_temp_c,
        string? beer_type,
        string? features
    )
    {
        Sku = sku;
        Name = name;
        Brewery = brewery;
        Rating = rating;
        Category = category;
        Sub_category_1 = sub_category_1;
        Sub_category_2 = sub_category_2;
        Sub_category_3 = sub_category_3;
        Description = description;
        Region = region;
        Country = country;
        Abv = abv;
        Ibu = ibu;
        Calories_per_serving_12oz = calories_per_serving_12oz;
        Carbs_per_serving_12oz = carbs_per_serving_12oz;
        Tasting_notes = tasting_notes;
        Food_pairing = food_pairing;
        Suggested_glassware = suggested_glassware;
        Serving_temp_f = serving_temp_f;
        Serving_temp_c = serving_temp_c;
        Beer_type = beer_type;
        Features = features;
    }

    public Birrerie() {}
}

public class Root
{
    [JsonPropertyName("code")]
    public int code { get; set; }

    [JsonPropertyName("error")]
    public bool error { get; set; }

    [JsonPropertyName("data")]
    public List<Birrerie>? data { get; set; }
}
