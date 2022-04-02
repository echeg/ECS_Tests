using System;
using Entitas;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.Entitas{


class System132 : IExecuteSystem{
  readonly GameContext _context;
  private readonly IGroup<GameEntity> _group;
  public System132(GameContext context)
  {
  _context = context;
  _group = _context.GetGroup(GameMatcher.AllOf(GameMatcher.EcsGeneratorEntitasComponent432,GameMatcher.EcsGeneratorEntitasComponent283,GameMatcher.EcsGeneratorEntitasComponent224));
  }
 public void Execute() {
  var entities = _group.GetEntities();
  for (var i = 0; i<entities.Length; i++) {
   var q = 0;   var entity = entities[i];
  }
 }
}

}
