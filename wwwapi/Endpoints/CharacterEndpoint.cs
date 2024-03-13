using Microsoft.AspNetCore.Mvc;
using wwwapi.Models;
using wwwapi.Repository;

namespace wwwapi.Endpoints
{
    public static class CharacterEndpoint
    {

        public static void ConfigureCharacterEndpoint(this WebApplication app)
        {
            var characterGroup = app.MapGroup("character");

            characterGroup.MapGet("", GetCharacters);
            characterGroup.MapGet("/abilties/{characterId}", GetAbilityScores);
            characterGroup.MapGet("/styles/{characterId}", GetStyle);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetCharacters(IRepository<Character> repository)
        {
            IEnumerable<Character> characters = await repository.Get();
            if ( characters == null) 
                return TypedResults.NotFound("No characters found"); 

            return TypedResults.Ok(characters);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static IResult GetAbilityScores(IRepository<AbilityScores> repository, int id)
        {
            IQueryable<AbilityScores> abilityScores = repository.GetByCondition(x => x.CharacterId == id);
            if (abilityScores == null) return TypedResults.NotFound("Ability scores not found"); 
            return TypedResults.Ok(abilityScores);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static IResult GetStyle(IRepository<Style> repository, int id)
        {
            IQueryable<Style> style = repository.GetByCondition(x => x.CharacterId == id);
            if (style == null) return TypedResults.NotFound("Ability scores not found");
            return TypedResults.Ok(style);
        }


    }
}
