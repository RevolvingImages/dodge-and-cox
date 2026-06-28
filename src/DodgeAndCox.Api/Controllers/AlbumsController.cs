using DodgeAndCox.Models;
using Microsoft.AspNetCore.Mvc;

namespace DodgeAndCox.Controllers;

[ApiController]
[Route("albums")]
public class AlbumsController : ControllerBase
{
    private static readonly IReadOnlyList<Album> MockAlbums =
    [
        new(1,  "Master of Puppets",          "Metallica",         1986, "Thrash Metal",           "Elektra Records",      8,  54),
        new(2,  "Vulgar Display of Power",    "Pantera",           1992, "Groove Metal",           "ATCO Records",        12,  53),
        new(3,  "Lateralus",                  "Tool",              2001, "Progressive Metal",      "Volcano Records",     13,  79),
        new(4,  "Toxicity",                   "System of a Down",  2001, "Alternative Metal",      "American Recordings", 14,  41),
        new(5,  "Blackwater Park",            "Opeth",             2001, "Progressive Death Metal", "Music for Nations",   7,  67),
        new(6,  "Leviathan",                  "Mastodon",          2004, "Sludge Metal",           "Relapse Records",      9,  47),
        new(7,  "Ashes of the Wake",          "Lamb of God",       2004, "Groove Metal",           "Epic Records",        11,  46),
        new(8,  "From Mars to Sirius",        "Gojira",            2005, "Progressive Death Metal", "Listenable Records", 10,  66),
        new(9,  "ObZen",                      "Meshuggah",         2008, "Technical Metal",        "Nuclear Blast",        8,  53),
        new(10, "The Satanist",               "Behemoth",          2014, "Death/Black Metal",      "Nuclear Blast",        9,  40),
    ];

    [HttpGet]
    public ActionResult<IReadOnlyList<Album>> GetAll() => Ok(MockAlbums);

    [HttpGet("{id:int}")]
    public ActionResult<Album> GetById(int id)
    {
        var album = MockAlbums.FirstOrDefault(a => a.Id == id);
        return album is null ? NotFound() : Ok(album);
    }
}
