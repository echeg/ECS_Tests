using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System234 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component321> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component349>())
   {
    entity.Del<Component349>();
   }
   else
   {
    entity.Replace(new Component349());
   }
  }
 }
}

}
