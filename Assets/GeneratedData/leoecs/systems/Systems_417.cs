using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System417 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component415,Component245,Component273> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component356>())
   {
    q+=1;
    var com = entity.Get<Component356>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
