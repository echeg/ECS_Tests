using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System145 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component88,Component159,Component50> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component339>())
   {
    entity.Del<Component339>();
   }
   else
   {
    entity.Replace(new Component339());
   }
  }
 }
}

}
