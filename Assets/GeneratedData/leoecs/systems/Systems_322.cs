using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System322 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component131> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component490>())
   {
    entity.Del<Component490>();
   }
   else
   {
    entity.Replace(new Component490());
   }
  }
 }
}

}
