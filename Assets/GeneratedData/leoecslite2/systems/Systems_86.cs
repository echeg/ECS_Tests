using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite2 {


class System86 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component431>().Inc<Component209>().Inc<Component61>().Inc<Component202>().End();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
   if (_world.GetPool<Component320>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component320>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component10>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component10>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component115>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component115>().Get(entity);
   }
   else
   {
    q-=1;
   }
   if (_world.GetPool<Component405>().Has(entity))
   {
    q+=1;
    var component1 = _world.GetPool<Component405>().Get(entity);
   }
   else
   {
    q-=1;
   }
  }
 }
}

}
