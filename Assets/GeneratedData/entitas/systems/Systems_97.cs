using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System97 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System97(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent190,GameMatcher.EcsGeneratorEntitasComponent292,GameMatcher.EcsGeneratorEntitasComponent111,GameMatcher.EcsGeneratorEntitasComponent358));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = _context.CreateEntity();
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent399,new Component399());
  }
 }
}

}
