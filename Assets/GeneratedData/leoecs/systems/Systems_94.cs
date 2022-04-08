using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System94 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component235> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component156>())
   {
    q+=1;
    var com = entity.Get<Component156>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component47>())
   {
    q+=1;
    var com = entity.Get<Component47>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component45>())
   {
    q+=1;
    var com = entity.Get<Component45>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component491>())
   {
    q+=1;
    var com = entity.Get<Component491>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
