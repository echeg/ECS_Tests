using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System56 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component370,Component204,Component241> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component26>())
   {
    q+=1;
    var com = entity.Get<Component26>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component163>())
   {
    q+=1;
    var com = entity.Get<Component163>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component282>())
   {
    q+=1;
    var com = entity.Get<Component282>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component408>())
   {
    q+=1;
    var com = entity.Get<Component408>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
