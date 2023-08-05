using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System149 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component444,Component326,Component443,Component406> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component15>())
   {
    entity.Del<Component15>();
   }
   else
   {
    entity.Replace(new Component15());
   }
  }
 }
}

}
