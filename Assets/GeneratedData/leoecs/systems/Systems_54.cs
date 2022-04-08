using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System54 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component332,Component25> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component55>())
   {
    q+=1;
    var com = entity.Get<Component55>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component378>())
   {
    q+=1;
    var com = entity.Get<Component378>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component264>())
   {
    q+=1;
    var com = entity.Get<Component264>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component80>())
   {
    q+=1;
    var com = entity.Get<Component80>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
