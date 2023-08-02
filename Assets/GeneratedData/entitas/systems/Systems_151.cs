using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System151 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System151(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent481,GameMatcher.EcsGeneratorEntitasComponent368));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var q = 0;   var entity = entities[i];
  }
 }
}

}