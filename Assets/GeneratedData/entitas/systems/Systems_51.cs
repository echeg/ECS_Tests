using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System51 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System51(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent363,GameMatcher.EcsGeneratorEntitasComponent402,GameMatcher.EcsGeneratorEntitasComponent492));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = _context.CreateEntity();
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent292,new Component292());
  }
 }
}

}
