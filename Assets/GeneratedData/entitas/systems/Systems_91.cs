using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System91 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System91(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent234));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var e = _context.CreateEntity();
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasTicksCooldown,new TicksCooldownComponent(10));
   e.AddComponent(GameComponentsLookup.EcsGeneratorEntitasComponent265,new Component265());
  }
 }
}

}