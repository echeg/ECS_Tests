using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System456 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component266,Component405,Component337,Component27> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component115>())
   {
    q+=1;
    var com = entity.Get<Component115>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
