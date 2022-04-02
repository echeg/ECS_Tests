using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System180 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System180(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent351,GameMatcher.EcsGeneratorEntitasComponent77,GameMatcher.EcsGeneratorEntitasComponent274,GameMatcher.EcsGeneratorEntitasComponent408));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var q = 0;   var entity = entities[i];
  }
 }
}

}
