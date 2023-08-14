using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System390 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component372,Component208> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component402>())
   {
    entity.Del<Component402>();
   }
   else
   {
    entity.Replace(new Component402());
   }
  }
 }
}

}
