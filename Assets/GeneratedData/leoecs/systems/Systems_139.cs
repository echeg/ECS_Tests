using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System139 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component446,Component269> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component396>())
   {
    entity.Del<Component396>();
   }
   else
   {
    entity.Replace(new Component396());
   }
  }
 }
}

}
