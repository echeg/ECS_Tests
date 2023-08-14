using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System264 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component163> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component433>())
   {
    entity.Del<Component433>();
   }
   else
   {
    entity.Replace(new Component433());
   }
  }
 }
}

}
