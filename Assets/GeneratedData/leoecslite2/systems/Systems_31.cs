using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System31 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component163>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component104>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component104>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component189>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component189>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component317>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component317>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component480>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component480>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
