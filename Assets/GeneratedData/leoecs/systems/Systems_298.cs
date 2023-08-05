using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System298 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component109> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component161>())
   {
    q+=1;
    var com = entity.Get<Component161>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component135>())
   {
    q+=1;
    var com = entity.Get<Component135>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component309>())
   {
    q+=1;
    var com = entity.Get<Component309>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component446>())
   {
    q+=1;
    var com = entity.Get<Component446>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
