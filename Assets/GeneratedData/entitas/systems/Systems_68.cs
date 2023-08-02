using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System68 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System68(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent451));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = _context.CreateEntity();
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent201,new Component201());
  }
 }
}

}